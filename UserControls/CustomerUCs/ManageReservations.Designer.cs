namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class ManageReservations
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
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            CheckInDatePicker = new DateTimePicker();
            CheckOutPicker = new DateTimePicker();
            ReservationsTable = new DataGridView();
            EditBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(61, 64);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(144, 28);
            lblCheckIn.TabIndex = 21;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOut.Location = new Point(61, 147);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(158, 28);
            lblCheckOut.TabIndex = 22;
            lblCheckOut.Text = "Check-out Date";
            // 
            // CheckInDatePicker
            // 
            CheckInDatePicker.CustomFormat = "dd /MMMM/ yyyy";
            CheckInDatePicker.Format = DateTimePickerFormat.Custom;
            CheckInDatePicker.Location = new Point(61, 95);
            CheckInDatePicker.Name = "CheckInDatePicker";
            CheckInDatePicker.Size = new Size(250, 27);
            CheckInDatePicker.TabIndex = 24;
            // 
            // CheckOutPicker
            // 
            CheckOutPicker.CustomFormat = "dd /MMMM/ yyyy";
            CheckOutPicker.Format = DateTimePickerFormat.Custom;
            CheckOutPicker.Location = new Point(61, 177);
            CheckOutPicker.Name = "CheckOutPicker";
            CheckOutPicker.Size = new Size(250, 27);
            CheckOutPicker.TabIndex = 25;
            // 
            // ReservationsTable
            // 
            ReservationsTable.BackgroundColor = Color.White;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTable.GridColor = Color.Black;
            ReservationsTable.Location = new Point(61, 355);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersWidth = 51;
            ReservationsTable.Size = new Size(529, 205);
            ReservationsTable.TabIndex = 26;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(61, 259);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(101, 36);
            EditBtn.TabIndex = 27;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(183, 259);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(101, 36);
            CancelBtn.TabIndex = 28;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(ReservationsTable);
            Controls.Add(CheckOutPicker);
            Controls.Add(CheckInDatePicker);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Name = "ManageReservations";
            Size = new Size(747, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCheckIn;
        private Label lblCheckOut;
        private DateTimePicker CheckInDatePicker;
        private DateTimePicker CheckOutPicker;
        private DataGridView ReservationsTable;
        private Button EditBtn;
        private Button CancelBtn;
    }
}
