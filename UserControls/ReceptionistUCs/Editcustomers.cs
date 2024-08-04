using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    public partial class Editcustomers : UserControl
    {
        public Editcustomers()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                string query = "SELECT username, password FROM Users WHERE role = 'Customer'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UpdateTBL.DataSource = dt;
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (UpdateTBL.SelectedRows.Count > 0)
            {
                string oldUsername = UpdateTBL.SelectedRows[0].Cells["username"].Value.ToString();
                string newUsername = txtusername.Text;
                string newPassword = txtpass.Text;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    string query = "UPDATE Users SET ";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(newUsername))
                    {
                        query += "username = @newUsername";
                        parameters.Add(new SqlParameter("@newUsername", newUsername));
                    }

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        if (parameters.Count > 0)
                        {
                            query += ", ";
                        }
                        query += "password = @newPassword";
                        parameters.Add(new SqlParameter("@newPassword", newPassword));
                    }

                    query += " WHERE username = @oldUsername";
                    parameters.Add(new SqlParameter("@oldUsername", oldUsername));

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                            LoadCustomers(); // Reload the updated list
                        }
                        else
                        {
                            MessageBox.Show("Error: Failed to update the customer.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }
    }
}