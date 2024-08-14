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

namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    public partial class ProfitReport : UserControl
    {
        public ProfitReport()
        {
            InitializeComponent();
        }

        private void ProfitReport_Load(object sender, EventArgs e)
        {
            Reservations r1 = new Reservations();
            lblProfit.Text = $"RM " + r1.getProfit();
        }
    }
}
