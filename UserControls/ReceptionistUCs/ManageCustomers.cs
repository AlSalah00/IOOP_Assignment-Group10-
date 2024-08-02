using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    public partial class ManageCustomers : UserControl
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            UsersTable.AutoGenerateColumns = false; // Disable auto generation of columns
            UsersTable.Columns.Clear();
            UsersTable.Columns.Add("Username", "Username");
            UsersTable.Columns.Add("Email", "Email");
            UsersTable.Columns.Add("Password", "Password");

            // Retrieving user details from the database
            List<User> allUsers = User.viewAll();
            var Customer = allUsers.Where(u => u.Role == "Customer").ToList();

            // Populating DataGridView with user details
            foreach (User user in Customer)
            {
                UsersTable.Rows.Add(user.Username, user.Password, user.Email);
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            // Checking if text boxes are empty
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields.");
            }

            else
            {
                string role = "Customer";

                // Adding a new user to the database
                User u1 = new User(txtUserName.Text, txtPassword.Text, txtEmail.Text, role);
                u1.addUser();
                RefreshTable();
                txtUserName.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
            }
        }



        private void AddUserBtn_Click_1(object sender, EventArgs e)//IGNORE
        {
            // Checking if text boxes are empty
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields.");
            }

            else
            {
                string role = "Customer";

                // Adding a new user to the database
                User u1 = new User(txtUserName.Text, txtPassword.Text, txtEmail.Text, role);
                u1.addUser();
                RefreshTable();
                txtUserName.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
            }

        }



        private void DelUserBtn_Click(object sender, EventArgs e)
        {
            if (UsersTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = UsersTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                // Checking if value is not null and is a string
                if (value != null && value is string stringValue)
                {
                    string username = stringValue;

                    // Making sure that username is not null
                    if (!string.IsNullOrEmpty(username))
                    {
                        User u1 = new User(username);
                        u1.deleteUser();
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to delete user.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No user selected.");

        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
