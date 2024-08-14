using IOOP_Assignment_Group10_.Classes;
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
    public partial class UpdateProfileRec : UserControl
    {
        public UpdateProfileRec(string n)
        {
            InitializeComponent();
            Name = n;
        }
       

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string newPass = txtPassword.Text;

            if (!string.IsNullOrEmpty(newUsername) &&
                !string.IsNullOrEmpty(newPass))
            {
                User u1 = new User(Name);
                u1.updateProfile(newUsername, newPass);
            }
            else
                MessageBox.Show("Error: Please fill all fields.");
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}