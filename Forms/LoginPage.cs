using System;
using System.Collections;
using System.Collections.Generic;
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

namespace IOOP_Assignment_Group10_
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))
            {
                User u1 = new User();
                string status = u1.Login(txtUsername.Text, txtPassword.Text);

                if (string.IsNullOrEmpty(status))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(status);
                }
            }
            else
            {
                MessageBox.Show("Please enter your details.");
            }
        }
    }
}
