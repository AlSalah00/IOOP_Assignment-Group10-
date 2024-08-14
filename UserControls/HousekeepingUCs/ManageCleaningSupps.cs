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
    public partial class ManageCleaningSupps : UserControl
    {
        public ManageCleaningSupps()
        {
            InitializeComponent();
            RefreshTable();
        }


        private void RefreshTable()
        {
            SuppsTable.AutoGenerateColumns = false;
            SuppsTable.Columns.Clear();
            SuppsTable.Columns.Add("ItemID", "ItemID");
            SuppsTable.Columns.Add("ItemName", "ItemName");
            SuppsTable.Columns.Add("ItemQuantity", "ItemQuantity");
            SuppsTable.Columns.Add("ItemPrice", "ItemPrice");

            List<Supplies> supps = Supplies.viewAll();

            foreach (Supplies sup in supps)
            {
                SuppsTable.Rows.Add(sup.ItemID, sup.ItemName, sup.Quantity, sup.ItemPrice);
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtName.Text) ||
                 !string.IsNullOrEmpty(txtQnt.Text) ||
                 !string.IsNullOrEmpty(txtPrice.Text))
            {
                string iteName = txtName.Text;
                int itemQty = int.Parse(txtQnt.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                decimal total = price * itemQty;
                Supplies s1 = new Supplies("ID", iteName, itemQty, total);
                s1.addItem();
                RefreshTable();
            }
            else
                MessageBox.Show("Error: Please fill all fields");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SuppsTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = SuppsTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is string strValue)
                {
                    string itemID = strValue;

                    if (itemID != null)
                    {
                        int qty = int.Parse(txtQnt.Text);
                        decimal price = decimal.Parse(txtPrice.Text);
                        decimal total = price * qty;

                        Supplies s1 = new Supplies(itemID);
                        s1.editItem(txtName.Text, qty, total);
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to update suppplies.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No item selected.");
        }

        private void SuppsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SuppsTable.CurrentRow != null)
            {
                DataGridViewRow selectedRow = SuppsTable.CurrentRow;

                txtName.Text = selectedRow.Cells[1].Value?.ToString();
                txtQnt.Text = selectedRow.Cells[2].Value?.ToString();

                string? total = selectedRow.Cells[3].Value?.ToString();

                if (total != null)
                {
                    decimal price = (decimal.Parse(total) / int.Parse(txtQnt.Text));
                    txtPrice.Text = price.ToString();
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (SuppsTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = SuppsTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is string strValue)
                {
                    string itemID = strValue;

                    if (itemID != null)
                    {
                        Supplies s1 = new Supplies(itemID);
                        s1.delItem();
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to update suppplies.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No item selected.");
        }
    }
}
