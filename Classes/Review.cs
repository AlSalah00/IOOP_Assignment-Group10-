using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class Review
    {
        private string resID;
        private string username;
        private string rating;
        private string review;
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

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Reviews
        {
            get { return review; }
            set { review = value; }
        }

        public Review(string resID, string username, string rating, string review)
        {
            this.resID = resID;
            this.username = username;
            this.rating = rating;
            this.review = review;
        }

        public void addReview()
        {
            con.Open();

            string query = "INSERT INTO Reviews (resID, username, rating, review) VALUES (@resID, @username, @rating, @review)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@review", review);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Review submitted. Thank you.");
                }
                else
                    MessageBox.Show("Error: Failed to submit.");
            }
            con.Close();
        }

        public static List<Review> viewAll()
        {
            List<Review> revs = new List<Review>();
            con.Open();

            SqlCommand cmd = new SqlCommand("select resID, username, rating, review from Reviews", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string resID = rd.GetString(0);
                string username = rd.GetString(1);
                string rating = rd.GetString(2);
                string review = rd.GetString(3);

                Review rev = new Review(resID, username, rating, review);
                revs.Add(rev);
            }
            con.Close();
            return revs;
        }
    }
    
}
