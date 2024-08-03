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
        public UpdateProfileCus()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            User u1 = new User(txtUserName.Text, txtPassword.Text);
            u1.updateProfile();
        }
    }
}
