using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class CleaningSchedule
    {
        private string username;
        private int roomNum;
        private string date;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public CleaningSchedule(string username, int roomNum, string date)
        {
            this.username = username;
            this.roomNum = roomNum;
            this.date = date;
        }

        public void assign()
        {
            con.Open();
            string query = "INSERT INTO CleaningSchedule (username, roomNum, date) VALUES (@username, @roomNum, @date)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@date", date);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cleaning schedule assigned successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to assign.");
                }
            }
            con.Close();

        }
    }
}
