namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    partial class RoomCSCH_HK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RoomCSCHTable = new DataGridView();
            lblUCSCH = new Label();
            ((System.ComponentModel.ISupportInitialize)RoomCSCHTable).BeginInit();
            SuspendLayout();
            // 
            // RoomCSCHTable
            // 
            RoomCSCHTable.BackgroundColor = Color.White;
            RoomCSCHTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomCSCHTable.GridColor = Color.Black;
            RoomCSCHTable.Location = new Point(61, 160);
            RoomCSCHTable.Name = "RoomCSCHTable";
            RoomCSCHTable.RowHeadersWidth = 51;
            RoomCSCHTable.Size = new Size(441, 318);
            RoomCSCHTable.TabIndex = 0;
            // 
            // lblUCSCH
            // 
            lblUCSCH.AutoSize = true;
            lblUCSCH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUCSCH.Location = new Point(61, 64);
            lblUCSCH.Name = "lblUCSCH";
            lblUCSCH.Size = new Size(287, 28);
            lblUCSCH.TabIndex = 2;
            lblUCSCH.Text = "Upcoming Cleaning Schedule";
            // 
            // RoomCSCH_HK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblUCSCH);
            Controls.Add(RoomCSCHTable);
            Name = "RoomCSCH_HK";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)RoomCSCHTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomCSCHTable;
        private Label lblUCSCH;
    }
}
