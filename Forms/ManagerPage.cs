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
        private Color defaultColor = Color.Navy;
        private Button[] buttons;
        public ManagerPage(string n)
        {
            InitializeComponent();
            Name = n;
            ManageUsers mu = new ManageUsers();
            addUserControl(mu);

            buttons = new Button[] { UAccBtn, RoomInfBtn, RCSBtn, ROBtn, CRBtn, PRBtn, LOBtn_M };

            foreach (Button btn in buttons)
            {
                btn.Click += Button_Click;
            }

            HighlightButton(UAccBtn);
        }

        private void Button_Click(object? sender, EventArgs e)
        {

            if (sender is Button clickedButton)
            {
                // Reset all buttons to default color
                foreach (Button btn in buttons)
                {
                    btn.BackColor = defaultColor;
                }

                // Highlight the clicked button
                HighlightButton(clickedButton);
            }

        }

        private void HighlightButton(Button button)
        {
            button.BackColor = highlight;
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
            lblIdentity.Text = $"Welcome, {Name}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            addUserControl(mu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomInfo ri = new RoomInfo();
            addUserControl(ri);
        }

        private void RCSBtn_Click(object sender, EventArgs e)
        {
            RoomCSH roomCSH = new RoomCSH();
            addUserControl(roomCSH);
        }

        private void ROBtn_Click(object sender, EventArgs e)
        {
            RoomOccupancy ro = new RoomOccupancy();
            addUserControl(ro);
        }

        private void CRBtn_Click(object sender, EventArgs e)
        {
            CustomerReviews cr = new CustomerReviews();
            addUserControl(cr);
        }

        private void PRBtn_Click(object sender, EventArgs e)
        {
            ProfitReport pr = new ProfitReport();
            addUserControl(pr);
        }

        private void LOBtn_M_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
