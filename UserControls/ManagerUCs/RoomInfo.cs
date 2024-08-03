using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    public partial class RoomInfo : UserControl
    {
        public RoomInfo()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            RoomInfoTable.AutoGenerateColumns = false;
            RoomInfoTable.Columns.Clear();
            RoomInfoTable.Columns.Add("RoomNum", "RoomNum");
            RoomInfoTable.Columns.Add("RoomType", "RoomType");
            RoomInfoTable.Columns.Add("Amenities", "Amenities");
            RoomInfoTable.Columns.Add("Price", "Price");
            RoomInfoTable.Columns.Add("RoomDetails", "RoomDetails");
            RoomInfoTable.Columns.Add("Status", "Status");

            List<Room> rooms = Room.viewAll();

            foreach (Room room in rooms)
            {
                RoomInfoTable.Rows.Add(room.RoomNum, room.RoomType, room.Amenities, room.Price, room.RoomDetails, room.Status);
            }
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            string noOfRooms = NoOfRoomsPicker.Value.ToString();
            string roomDesc = txtRoomDesc.Text;
            string amenities = string.Empty;

            if (CHBFreeWF.Checked)
            {
                amenities += "Free Wi-Fi";
            }
            if (CHBFreeBF.Checked)
            {
                amenities += ", Free Breakfast";
            }
            if (CHBAC.Checked)
            {
                amenities += ", Air Conditioning";
            }
            if (CHBLS.Checked)
            {
                amenities += ", Laundry Services";
            }
            if (CHBGP.Checked)
            {
                amenities += ", Gym and Pool";
            }
            if (CHBPF.Checked)
            {
                amenities += ", Pet-Friendly";
            }
            if (string.IsNullOrEmpty(amenities))
            {
                amenities += "None";
            }

            int roomNum = int.Parse(txtRoomNo.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            string roomDetails = (roomDesc + " No. of rooms: " + noOfRooms);

            if (!string.IsNullOrEmpty(CBRoomType.Text) ||
                !string.IsNullOrEmpty(txtRoomNo.Text) ||
                !string.IsNullOrEmpty(amenities) ||
                !string.IsNullOrEmpty(txtPrice.Text) && int.Parse(txtPrice.Text) > 0 && int.Parse(txtRoomNo.Text) > 0)
            {
                Room r1 = new Room(roomNum, CBRoomType.Text, amenities, price, roomDetails, "Available");
                r1.addRoom();
                txtRoomNo.Clear();
                txtPrice.Clear();
                txtRoomDesc.Clear();
                NoOfRoomsPicker.ResetText();
                RefreshTable();
            }
        }

        private void DelRoomBtn_Click(object sender, EventArgs e)
        {
            if (RoomInfoTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RoomInfoTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is int intValue)
                {

                    int roomNum = (int)value;

                    if (roomNum > 0)
                    {
                        Room r1 = new Room(roomNum);
                        r1.deleteRoom();
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to delete room.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No room selected.");
        }

        private void RoomInfoTable_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomInfoTable.CurrentRow != null)
            {
                DataGridViewRow selectedRow = RoomInfoTable.CurrentRow;

                txtRoomNo.Text = selectedRow.Cells[0].Value?.ToString();
                CBRoomType.Text = selectedRow.Cells[1].Value?.ToString();
                string? amenities = selectedRow.Cells[2].Value?.ToString();
                txtPrice.Text = selectedRow.Cells[3].Value?.ToString();
                txtRoomDesc.Text = selectedRow.Cells[4].Value?.ToString();

                if (amenities != null && amenities.Contains("Free Wi-Fi", StringComparison.OrdinalIgnoreCase))
                {
                    CHBFreeWF.Checked = true;
                }
                else
                    CHBFreeWF.Checked = false;

                if (amenities != null && amenities.Contains("Free Breakfast", StringComparison.OrdinalIgnoreCase))
                {
                    CHBFreeBF.Checked = true;
                }
                else
                    CHBFreeBF.Checked = false;

                if (amenities != null && amenities.Contains("Air Conditioning", StringComparison.OrdinalIgnoreCase))
                {
                    CHBAC.Checked = true;
                }
                else
                    CHBAC.Checked = false;

                if (amenities != null && amenities.Contains("Laundry Services", StringComparison.OrdinalIgnoreCase))
                {
                    CHBLS.Checked = true;
                }
                else
                    CHBLS.Checked = false;

                if (amenities != null && amenities.Contains("Gym and Pool", StringComparison.OrdinalIgnoreCase))
                {
                    CHBGP.Checked = true;
                }
                else
                    CHBGP.Checked = false;

                if (amenities != null && amenities.Contains("Pet-Friendly", StringComparison.OrdinalIgnoreCase))
                {
                    CHBPF.Checked = true;
                }
                else
                {
                    CHBPF.Checked = false;
                }
            }
        }

        private void EditRoomBtn_Click(object sender, EventArgs e)
        {
            string amenities = string.Empty;

            if (CHBFreeWF.Checked)
            {
                amenities += "Free Wi-Fi";
            }
            if (CHBFreeBF.Checked)
            {
                amenities += ", Free Breakfast";
            }
            if (CHBAC.Checked)
            {
                amenities += ", Air Conditioning";
            }
            if (CHBLS.Checked)
            {
                amenities += ", Laundry Services";
            }
            if (CHBGP.Checked)
            {
                amenities += ", Gym and Pool";
            }
            if (CHBPF.Checked)
            {
                amenities += ", Pet-Friendly";
            }
            if (string.IsNullOrEmpty(amenities))
            {
                amenities += "None";
            }

            if (RoomInfoTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RoomInfoTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is int)
                {

                    int roomNum = (int)value;

                    if (roomNum > 0)
                    {
                        Room r1 = new Room(roomNum);
                        r1.editRoom(roomNum, CBRoomType.Text, amenities, decimal.Parse(txtPrice.Text), txtRoomDesc.Text);
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to update room.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No room selected.");
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (sender is TextBox txtBox)
            {
                string currentText = txtPrice.Text;

                // Allowing only numbers for price textbox
                if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                {
                    e.Handled = true;
                }

                else if (ch == 46)
                {
                    // Allow period only if there is no existing period in the text
                    if (currentText.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void RoomInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
