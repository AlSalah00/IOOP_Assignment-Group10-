using IOOP_Assignment_Group10_.UserControls.ManagerUCs;
using IOOP_Assignment_Group10_.UserControls.ReceptionistUCs;
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
    public partial class ReceptionistPage : Form
    {

        private Color highlight = ColorTranslator.FromHtml("#0066cc");
        private Color defaultColor = Color.Navy;
        private Button[] buttons;

        public ReceptionistPage(string n)
        {
            InitializeComponent();
            Name = n;
            ManageCustomers mc = new ManageCustomers();
            addUserControl(mc);

            buttons = new Button[] { ManageCustomersBtn, SearchForResBtn, CheckInBtn, checkOutBtn, UpdateProfileBtn_Rec, LOBtn_RCP};

            foreach (Button btn in buttons)
            {
                btn.Click += Button_Click;
            }

            HighlightButton(ManageCustomersBtn);
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

        private void ReceptionistPage_Load(object sender, EventArgs e)
        {
            lblIdentityRCP.Text = $"Welcome, {Name}";
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ReceptionistPanel.Controls.Add(userControl);
            ReceptionistPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void UAccBtn_Click(object sender, EventArgs e)
        {
            ManageCustomers mc = new ManageCustomers();
            addUserControl(mc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchReservation sr = new SearchReservation();
            addUserControl(sr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckInCUS ci = new CheckInCUS();
            addUserControl(ci);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckOutCUS co = new CheckOutCUS();
            addUserControl(co);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProfileRec update = new UpdateProfileRec(Name);
            addUserControl(update);
        }

        private void LOBtn_RCP_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
