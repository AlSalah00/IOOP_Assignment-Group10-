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

namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class UpdateProfileCus : UserControl
    {
        public UpdateProfileCus(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string newUsername = txtUserName.Text;
            string newPassword = txtPassword.Text;

            if (!string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newPassword))
            {
                User u1 = new User(Name);
                u1.updateProfile(newUsername, newPassword);
            }
            else
                MessageBox.Show("Error: Please fill all fields.");
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
