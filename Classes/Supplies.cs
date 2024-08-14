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
        private string itemID;
        private string itemName;
        private int quantity;
        private decimal itemPrice;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        
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

        public Supplies(string itemID, string itemName, int quantity, decimal itemPrice) 
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }


        public Supplies(string itemID)
        {
            this.itemID = itemID;
            this.itemName = string.Empty;
        }


        public string genereateID()
        {
            return $"I1{new Random().Next(1000, 9999)}";
        }

        public void addItem()
        {
            con.Open();
            string itemID = genereateID();
            string query = "INSERT INTO CleaningSupps (itemID, itemName, quantity, itemPrice) VALUES (@itemID, @itemName, @quantity, @itemPrice)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@itemID", itemID);
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


        public void editItem(string itemName, int quantity, decimal itemPrice)
        {
            con.Open();
            string query = "UPDATE CleaningSupps SET itemName = @itemName, quantity = @quantity, itemPrice = @itemPrice WHERE itemID = @itemID";

                
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@itemID", itemID);
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


        public void delItem()
        {
            con.Open();
            string query = "DELETE FROM CleaningSupps WHERE itemID = @itemID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@itemID", itemID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Failed to delete item.");
                }
            }
            con.Close();
        }


        public static List<Supplies> viewAll()
        {
            List<Supplies> supps = new List<Supplies>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select itemID, itemName, quantity, itemPrice from CleaningSupps", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string itemID = rd.GetString(0);
                string itemName = rd.GetString(1);
                int quantity = rd.GetInt32(2);
                decimal itemPrice = rd.GetDecimal(3);

                Supplies supp = new Supplies(itemID, itemName, quantity, itemPrice);
                supps.Add(supp);
            }
            con.Close();
            return supps;
        }
    }
}
