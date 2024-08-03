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
        private DateTime date;
        private string status;
        private string issues;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public string Issues
        {
            get { return issues; }
            set { issues = value; }
        }

        public CleaningSchedule(string username, int roomNum, DateTime date, string status, string issues)
        {
            this.username = username;
            this.roomNum = roomNum;
            this.date = date;
            this.status = status;
            this.issues = issues;
        }


        public CleaningSchedule(int roomNum)
        {
            this.roomNum = roomNum;
            this.username = string.Empty;
            this.status= string.Empty;
            this.issues = string.Empty;
        }

        public bool ScheduleExists(string username, DateTime date)
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM CleaningSchedule WHERE username = @username AND date = @date";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@date", date);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count > 0;
            }
        }

        public void assign()
        {
            if (ScheduleExists(username, date))
            {
                con.Open();
                string query = "INSERT INTO CleaningSchedule (username, roomNum, date, status, issues) VALUES (@username, @roomNum, @date, @status, @issues)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@roomNum", roomNum);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@issues", issues);

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
            else
                MessageBox.Show("Error: This housekeeper is already assigned to this date.");

        }

        public static List<CleaningSchedule> viewAll()
        {
            List<CleaningSchedule> schedules = new List<CleaningSchedule>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username, roomNum, date, status, issues from CleaningSchedule", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string username = rd.GetString(0);
                int roomNum = rd.GetInt32(1);
                DateTime date = rd.GetDateTime(2);
                string status = rd.GetString(3);
                string issues = rd.GetString(4);

                CleaningSchedule schedule = new CleaningSchedule(username, roomNum, date, status, issues);
                schedules.Add(schedule);
            }
            con.Close();
            return schedules;
        }


        public void updateRoomCleanliness(string status, string issues)
        {
            con.Open();

            string query = "UPDATE CleaningSchedule SET status = @status, issues = @issues WHERE roomNum = @roomNum";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@roomNum", roomNum);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@issues", issues);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room cleanliness updated successfully.");
                }
                else
                    MessageBox.Show("Error: Failed to update room cleanliness.");
            }
            con.Close();
        }
    }
}
