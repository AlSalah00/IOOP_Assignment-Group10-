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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class ManageReservations : UserControl
    {
        public ManageReservations()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            ReservationsTable.AutoGenerateColumns = false;
            ReservationsTable.Columns.Clear();
            ReservationsTable.Columns.Add("resID", "resID");
            ReservationsTable.Columns.Add("username", "username");
            ReservationsTable.Columns.Add("roomNum", "roomNum");
            ReservationsTable.Columns.Add("checkInDate", "checkInDate");
            ReservationsTable.Columns.Add("checkOutDate", "checkOutDate");
            ReservationsTable.Columns.Add("totalCharges", "totalCharges");
            ReservationsTable.Columns.Add("status", "status");
            ReservationsTable.Columns.Add("payment", "payment");

            List<Reservations> allres = Reservations.ViewAllReservations();
            var pending = allres.Where(u => u.Status == "Pending" && u.Username == Name).ToList();

            foreach (Reservations reservations in pending)
            {
                ReservationsTable.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            


            
        }
    }

}


