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

namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    public partial class UpdateProfile_HK : UserControl
    {
        public UpdateProfile_HK(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                string newUsername = txtUsername.Text;
                string newPass = txtPass.Text;

                User u1 = new User(Name);
                u1.updateProfile(newUsername, newPass);
            }
            else
                MessageBox.Show("Error: Please fill all fields.");
            txtUsername.Clear();
            txtPass.Clear();
        }
    }
}
