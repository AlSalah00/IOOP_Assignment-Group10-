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
    public partial class CustomerPage : Form
    {
        public CustomerPage(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            lblIdentityCus.Text = $"Welcome, {Name}";
        }
    }
}
