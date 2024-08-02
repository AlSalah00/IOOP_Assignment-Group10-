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
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        


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
        public Reservations(string resID, string username, int roomNum, DateTime checkinDate, DateTime checkoutDate, decimal totalCharges, string status)
        {
            this.resID = resID;
            this.username = username;
            this.roomNum = roomNum;
            this.checkinDate = checkinDate;
            this.checkoutDate = checkoutDate;
            this.totalCharges = totalCharges;
            this.status = status;
        }


        // Add a new reservation
        public  void AddReservation()
        {
            con.Open();
            string query = "INSERT INTO Reservations (resID, username, roomNum, checkInDate, checkOutDate, totalCharges, status) VALUES (@resID, @username, @roomNum, @checkinDate, @checkoutDate, @totalCharges, @status)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);

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
            string query = "UPDATE Reservations SET username = @username, roomNum = @roomNum, checkInDate = @checkinDate, checkOutDate = @checkoutDate, totalCharges = @totalCharges, status = @status WHERE ID = @ID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);

                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Reservation edited successfully.");
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

            SqlCommand cmd = new SqlCommand("select resID, username , roomNum, checkinDate,checkoutDate,totalCharges,status from Reservations", con);
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

                Reservations Res = new Reservations(resID, username, roomNum, checkinDate, checkoutDate, totalCharges, status);
                reservations.Add(Res);
            }
            con.Close();
            return reservations;
        }
        public void checkInCustomer()
        {
            con.Open();
            string query = "UPDATE Reservations SET resID = @resID, username = @username, roomNum = @roomNum, checkinDate = @checkinDate, checkoutDate = @checkoutDate, totalCharges = @totalCharges, status = @status";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Check-in successful.");
                }
                else
                {
                    MessageBox.Show("Error: Failed Check-in Customer. The Reservation may not exist.");
                }
            }
            con.Close();

        }
        public void CheckOutCustomer()
        {
            con.Open();
            string query = "UPDATE Reservations SET resID = @resID, username = @username, roomNum = @roomNum, checkinDate = @checkinDate, checkoutDate = @checkoutDate, totalCharges = @totalCharges, status = @status";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@checkinDate", checkinDate);
                cmd.Parameters.AddWithValue("@checkoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@totalCharges", totalCharges);
                cmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Check-out successful.");
                }
                else
                {
                    MessageBox.Show("Error: Failed Check-out Customer. The Reservation may not exist.");
                }
            }
            con.Close();

        }
        public void GetRowCount()
        {
            int rowCount = 0;
            string query = "SELECT COUNT(*) FROM Reservations";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    rowCount = (int)cmd.ExecuteScalar();
                }
            }

            int newIdNumber = rowCount + 1;
            
        }


    }
}