using IOOP_Assignment_Group10_.UserControls;
using IOOP_Assignment_Group10_.UserControls.ManagerUCs;
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
    public partial class ManagerPage : Form
    {

        private Color highlight = ColorTranslator.FromHtml("#0066cc");
        private Color Default = Color.Navy;
        public ManagerPage()
        {
            InitializeComponent();
            ManageUsers mu = new ManageUsers();
            addUserControl(mu);
            UAccBtn.BackColor = highlight;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ManagerPanel.Controls.Clear();
            ManagerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ManagerPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            addUserControl(mu);
            UAccBtn.BackColor = highlight;
            ROBtn.BackColor = Default;
            RCSBtn.BackColor = Default;
            RoomInfBtn.BackColor = Default;
            PRBtn.BackColor = Default;
            CRBtn.BackColor = Default;
            LOBtn_M.BackColor = Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomInfo ri = new RoomInfo();
            addUserControl(ri);
            RoomInfBtn.BackColor = highlight;
            UAccBtn.BackColor = Default;
            ROBtn.BackColor = Default;
            RCSBtn.BackColor = Default;
            PRBtn.BackColor = Default;
            CRBtn.BackColor = Default;
            LOBtn_M.BackColor = Default;
        }
    }
}
