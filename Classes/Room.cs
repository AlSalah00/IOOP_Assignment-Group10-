using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class Room
    {
        private string roomType;
        private string amenities;
        string roomDetails;
        string status;
        private decimal price;
        private int roomNum;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public string Amenities
        {
            get { return amenities; }
            set { amenities = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string RoomDetails
        {
            get { return roomDetails; }
            set { roomDetails = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Room(int roomNum, string roomType, string amenities, decimal price, string roomDetails, string status)
        {
            this.roomNum = roomNum;
            this.roomType = roomType;
            this.amenities = amenities;
            this.price = price;
            this.roomDetails = roomDetails;
            this.status = status;
        }

        public Room(int roomNum)
        {
            this.roomNum = roomNum;
            this.roomType = string.Empty;
            this.amenities = string.Empty;
            this.price = 0;
            this.roomDetails = string.Empty;
            this.status = string.Empty;
        }

        public void addRoom()
        {
            con.Open();
            string query = "INSERT INTO rooms (roomNum, roomType, amenities, price, roomDetails, status) VALUES (@roomNum, @roomType, @amenities, @price, @roomDetails, @status)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@amenities", amenities);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@roomDetails", roomDetails);
                cmd.Parameters.AddWithValue("status", status);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room added successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to add a new room.");
                }
            }
            con.Close();
        }

        public string GetRoomStatus(string roomNum)
        {
            string status = "";
            con.Open();
            string query = "SELECT status FROM rooms WHERE roomNum = @roomNum";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    status = reader["status"].ToString();
                }
                reader.Close();
            }
            con.Close();
            return status;
        }

        public void editRoom(int roomNum, string roomType, string amenities, decimal price, string roomDetails)
        {
            string currentStatus = GetRoomStatus(roomNum.ToString());

            con.Open();
            string query = "UPDATE rooms SET roomType = @roomType, amenities = @amenities, price = @price, roomDetails = @roomDetails, status = @status WHERE roomNum = @roomNum";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@amenities", amenities);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@roomDetails", roomDetails);
                cmd.Parameters.AddWithValue("@status", currentStatus);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to update the room. The room may not exist.");
                }
            }
            con.Close();
        }

        public void deleteRoom()
        {
            con.Open();

            string query = "DELETE FROM rooms WHERE roomNum = @roomNum";

            using ( SqlCommand cmd = new SqlCommand(query,con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to delete room.");
                }
            }

            con.Close();
        }

        public static List<Room> viewAll()
        {
            List<Room> rooms = new List<Room>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select roomNum, roomType, amenities, price, roomDetails, status from rooms", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int roomNum = rd.GetInt32(0);
                string roomType = rd.GetString(1);
                string amenities = rd.GetString(2);
                decimal price = rd.GetDecimal(3);
                string roomDetails = rd.GetString(4);
                string status = rd.GetString(5);

                Room room = new Room(roomNum, roomType, amenities, price, roomDetails, status);
                rooms.Add(room);
            }
            con.Close();
            return rooms;
        }
    }
}
