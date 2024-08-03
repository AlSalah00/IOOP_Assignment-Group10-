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
    public partial class RoomCSCH_HK : UserControl
    {
        public RoomCSCH_HK(string n)
        {
            InitializeComponent();
            Name = n;
            RefreshTable();
        }

        private void RefreshTable()
        {
            RoomCSCHTable.AutoGenerateColumns = false;
            RoomCSCHTable.Columns.Clear();
            RoomCSCHTable.Columns.Add("RoomNum", "RoomNum");
            RoomCSCHTable.Columns.Add("DateTime", "DateTime");
            RoomCSCHTable.Columns.Add("Status", "Status");
            RoomCSCHTable.Columns.Add("Issues", "Issues");

            List<CleaningSchedule> allSchedules = CleaningSchedule.viewAll();

            var userSchedules = allSchedules.Where(schedule => schedule.Username == Name);

            RoomCSCHTable.Rows.Clear();
            foreach (var schedule in userSchedules)
            {
                RoomCSCHTable.Rows.Add(schedule.RoomNum, schedule.Date, schedule.Status, schedule.Issues);
            }
        }
    }
}
