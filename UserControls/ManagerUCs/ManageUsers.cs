using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.UserControls
{
    public partial class ManageUsers : UserControl
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ignore this.
        }

        private void RefreshTable()
        {
            UsersTable.AutoGenerateColumns = false; // Disable auto generation of columns
            UsersTable.Columns.Clear();
            UsersTable.Columns.Add("Username", "Username");
            UsersTable.Columns.Add("Password", "Password");
            UsersTable.Columns.Add("Email", "Email");
            UsersTable.Columns.Add("Role", "Role");

            // Retrieving user details from the database
            List<User> users = User.viewAll();

            // Populating DataGridView with user details
            foreach (User user in users)
            {
                UsersTable.Rows.Add(user.Username, user.Password, user.Email, user.Role);
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
                string role = "Housekeeper";
                if (HouseKeeperRB.Checked)
                    role = "Housekeeper";
                else
                    role = "Receptionist";

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
            // Checking if a row is selected
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

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
