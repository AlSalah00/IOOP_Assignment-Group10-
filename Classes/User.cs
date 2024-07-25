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
    internal class User
    {
        private string username;
        private string password;
        private string email;
        private string role;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public User(string username, string email, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public User(string username)
        {
            this.username = username;
            password = string.Empty;
            email = string.Empty;
            role = string.Empty;
        }

        // Checking if user already exists
        private bool UserExists(string username)
        {           
            con.Open();           
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count == 0; // If count is 0, username is unique; otherwise, it exists
            }            

        }
        public void addUser()
        {
            if (UserExists(username))
            {

                con.Open();
                string query = "INSERT INTO Users (username, email, password, role) VALUES (@username, @email, @password, @role)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters to the query
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    // Executing the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to add a new user.");
                    }
                }
                con.Close();
            }
            else 
            {
                MessageBox.Show("Error: User already exists.");                
            }
        }

        public void deleteUser()
        {
            con.Open();

            string query = "DELETE FROM users WHERE username = @username";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to delete user.");
                }
            }

            con.Close();
        }

        public static List<User> viewAll()
        {
            List<User> users = new List<User>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username, email, password, role from users", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string username = rd.GetString(0);
                string email = rd.GetString(1);
                string password = rd.GetString(2);
                string role = rd.GetString(3);

                User user = new User(username, email, password, role);
                users.Add(user);
            }
            con.Close();
            return users;
        }
    }
}
