namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class RoomOccupancy
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
            RoomOccupancyTable = new DataGridView();
            lblRoomAvailability = new Label();
            RefreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RoomOccupancyTable).BeginInit();
            SuspendLayout();
            // 
            // RoomOccupancyTable
            // 
            RoomOccupancyTable.BackgroundColor = Color.White;
            RoomOccupancyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomOccupancyTable.GridColor = Color.Black;
            RoomOccupancyTable.Location = new Point(118, 322);
            RoomOccupancyTable.Name = "RoomOccupancyTable";
            RoomOccupancyTable.RowHeadersWidth = 51;
            RoomOccupancyTable.Size = new Size(280, 157);
            RoomOccupancyTable.TabIndex = 18;
            // 
            // lblRoomAvailability
            // 
            lblRoomAvailability.AutoSize = true;
            lblRoomAvailability.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomAvailability.Location = new Point(61, 64);
            lblRoomAvailability.Name = "lblRoomAvailability";
            lblRoomAvailability.Size = new Size(181, 28);
            lblRoomAvailability.TabIndex = 19;
            lblRoomAvailability.Text = "Room Availability";
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = SystemColors.HotTrack;
            RefreshBtn.FlatAppearance.BorderSize = 0;
            RefreshBtn.FlatStyle = FlatStyle.Flat;
            RefreshBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshBtn.ForeColor = Color.White;
            RefreshBtn.Location = new Point(118, 261);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(101, 36);
            RefreshBtn.TabIndex = 20;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // RoomOccupancy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RefreshBtn);
            Controls.Add(lblRoomAvailability);
            Controls.Add(RoomOccupancyTable);
            Name = "RoomOccupancy";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)RoomOccupancyTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomOccupancyTable;
        private Label lblRoomAvailability;
        private Button RefreshBtn;
    }
}
