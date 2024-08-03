using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class Reservations
    {
        private string resID;
        private string username;
        private int roomNum;
        private DateTime checkinDate;
        private DateTime checkoutDate;
        private string status;
        private decimal totalCharges;
        private string payment;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        
        public string ResID
        {
            get { return resID; }
            set { resID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public DateTime CheckinDate
        {
            get { return checkinDate; }
            set { checkinDate = value; }
        }

        public DateTime CheckoutDate
        {
            get { return checkoutDate; }
            set { checkoutDate = value; }
        }

        public decimal TotalCharges
        {
            get { return totalCharges; }
            set { totalCharges = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public string generateID()
        {
            return $"R1{new Random().Next(1000, 9999)}";
        }

        public Reservations(string resID, string username, int roomNum, DateTime checkinDate, DateTime checkoutDate, decimal totalCharges, string status, string payment)
        {
            this.resID = resID;
            this.username = username;
            this.roomNum = roomNum;
            this.checkinDate = checkinDate;
            this.checkoutDate = checkoutDate;
            this.totalCharges = totalCharges;
            this.status = status;
            this.payment = payment;
        }


        // Add a new reservation
        public  void AddReservation()
        {
            con.Open();
            string query = "INSERT INTO Reservations (resID, username, roomNum, checkInDate, checkOutDate, totalCharges, status, payment) VALUES (@resID, @username, @roomNum, @checkinDate, @checkoutDate, @totalCharges, @status, @payment)";
            string resID = generateID();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@payment", payment);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Reservation confirmed.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to confirm reservation.");
                }
            }

            con.Close();
            
        }

        // Edit an existing reservation
        public  void EditReservation()
        {
            con.Open();
            string query = "UPDATE Reservations SET username = @username, roomNum = @roomNum, checkInDate = @checkinDate, checkOutDate = @checkoutDate, totalCharges = @totalCharges, status = @status payment = @payment WHERE resID = @resID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@payment", payment);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Reservation updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to update the reservation. The reservation may not exist.");
                }
            }
            con.Close();
        }

        // Delete an existing reservation
        public void DeleteReservation()
        {
            con.Open();
            string query = "DELETE FROM Reservations WHERE roomNum = @roomNum";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Reservation Cancelled successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to Cancel Reservation.");
                }
            }

            con.Close();

        }

        // View all reservations
        public static List<Reservations> ViewAllReservations()
        {
            List<Reservations> reservations = new List<Reservations>();
            con.Open();

            SqlCommand cmd = new SqlCommand("select resID, username , roomNum, checkinDate, checkoutDate, totalCharges, status, payment from Reservations", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string resID = rd.GetString(0);
                string username = rd.GetString(1);
                int roomNum = rd.GetInt32(2);
                DateTime checkinDate = rd.GetDateTime(3);
                DateTime checkoutDate = rd.GetDateTime(4);
                Decimal totalCharges = rd.GetDecimal(5);
                string status = rd.GetString(6);
                string payment = rd.GetString(7);

                Reservations Res = new Reservations(resID, username, roomNum, checkinDate, checkoutDate, totalCharges, status, payment);
                reservations.Add(Res);
            }
            con.Close();
            return reservations;
        }
        public void checkInCustomer()
        {
            con.Open();

            // Update the Reservations table
            string query1 = "UPDATE Reservations SET status = @status WHERE resID = @resID";

            // Update the rooms table
            string query2 = "UPDATE rooms SET status = @roomStatus WHERE roomNum = @roomNum";

            using (SqlCommand cmd1 = new SqlCommand(query1, con))
            {
                cmd1.Parameters.AddWithValue("@resID", resID);
                cmd1.Parameters.AddWithValue("@status", "checked in");

                int rowsAffected1 = cmd1.ExecuteNonQuery();

                if (rowsAffected1 > 0)
                {
                    using (SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        cmd2.Parameters.AddWithValue("@roomNum", roomNum);
                        cmd2.Parameters.AddWithValue("@roomStatus", "occupied");

                        int rowsAffected2 = cmd2.ExecuteNonQuery();

                        if (rowsAffected2 > 0)
                        {
                            MessageBox.Show("Check-in successful and room status updated to occupied.");
                        }
                        else
                        {
                            MessageBox.Show("Check-in successful but failed to update room status.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Failed to check-in customer. The reservation may not exist.");
                }
            }

            con.Close();
        }
    }
}

public void CheckOutCustomer()
        {
            con.Open();
            string query = "UPDATE Reservations SET username = @username, roomNum = @roomNum, checkinDate = @checkinDate, checkoutDate = @checkoutDate, totalCharges = @totalCharges, status = @status payment = @payment WHERE resID = @resID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@payment", payment);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Check-out successful.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to check-out customer. The reservation may not exist.");
                }
            }
            con.Close();

        }

    }
}