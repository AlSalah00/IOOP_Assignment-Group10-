using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class Supplies
    {
        private string itemName;
        private int quantity;
        private decimal itemPrice;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string ItemName
        {
            get { return itemName; }
            set { ItemName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal ItemPrice
        {
            get { return itemPrice; }
            set { ItemPrice = value; }
        }

        public Supplies(string itemName, int quantity, decimal itemPrice) 
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }

        private bool ItemIsUnique(string itemName)
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM CleaningSupps WHERE itemName = @itemName";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@itemName", itemName);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count == 0; // If count is 0, itemName is unique otherwise, it exists
            }
        }

        public void addItem()
        {
            if (ItemIsUnique(itemName))
            {
                con.Open();
                string query = "INSERT INTO CleaningSupps (itemName, quantity, itemPrice) VALUES (@itemName, @quantity, @itemPrice)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@itemPrice", itemPrice);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to add a new item.");
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error: Item already exists.");
            }
        }


        public void editItem()
        {
            con.Open();
            string query = "UPDATE CleaningSupps SET itemName = @itemName, quantity = @quantity, itemPrice = @itemPrice WHERE itemName = @itemName";

            if (ItemIsUnique(itemName))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@itemPrice", itemPrice);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to update the item. The item may not exist.");
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error: Item already exists.");
            }
        }


        public void delItem()
        {
            con.Open();
            string query = "DELETE FROM CleaningSupps WHERE itemName = @itemName";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@itemName", itemName);

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


        public static List<Supplies> viewAll()
        {
            List<Supplies> supps = new List<Supplies>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select itemName, quantity, itemPrice from CleaningSupps", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string itemName = rd.GetString(0);
                int quantity = rd.GetInt32(1);
                decimal itemPrice = rd.GetDecimal(2);

                Supplies supp = new Supplies(itemName, quantity, itemPrice);
                supps.Add(supp);
            }
            con.Close();
            return supps;
        }
    }
}
