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
        private string price;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string RoomType { get => roomType; set => roomType = value; }
        public string Amenities { get => amenities; set => amenities = value; }
        public string Price { get => price; set => price = value; }

        public Room(string roomType, string amenities, string price)
        {
            this.roomType = roomType;
            this.amenities = amenities;
            this.price = price;
        }

        private void addRoom()
        {
            con.Open();
            string query = "INSERT INTO rooms (rooomtype, amenities, price) VALUES (@roomtype, @amenities, @price)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomtype", roomType);
                cmd.Parameters.AddWithValue("@amenities", Amenities);
                cmd.Parameters.AddWithValue("@price", Price);

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
    }
}
