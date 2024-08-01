using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.Forms
{
    public partial class HousekeepingPage : Form
    {
        public HousekeepingPage(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HousekeepingPage_Load(object sender, EventArgs e)
        {
            lblIdentityHK.Text = $"Welcome, {Name}";
        }

        private void LOBtn_HK_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
