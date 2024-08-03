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
    public partial class UpcomingReservations : UserControl
    {
        public UpcomingReservations()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            UpcomingResTBL.AutoGenerateColumns = false;
            UpcomingResTBL.Columns.Clear();
            UpcomingResTBL.Columns.Add("roomNum", "roomNum");
            UpcomingResTBL.Columns.Add("checkInDate", "checkInDate");

            List<Reservations> allres = Reservations.ViewAllReservations();
            var pending = allres.Where(u => u.Status == "Pending").ToList();

            foreach (Reservations reservations in pending)
            {
                UpcomingResTBL.Rows.Add(reservations.RoomNum, reservations.CheckinDate);
            }
        }
    }
}
