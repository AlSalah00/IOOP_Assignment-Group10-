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
            dateTimePicker2 = new DateTimePicker();
            ReservationsTable = new DataGridView();
            EditReservationBtn = new Button();
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
            lblCheckOut.Location = new Point(61, 146);
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
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd /MMMM/ yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(61, 177);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 25;
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
            // EditReservationBtn
            // 
            EditReservationBtn.BackColor = SystemColors.HotTrack;
            EditReservationBtn.FlatAppearance.BorderSize = 0;
            EditReservationBtn.FlatStyle = FlatStyle.Flat;
            EditReservationBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditReservationBtn.ForeColor = Color.White;
            EditReservationBtn.Location = new Point(61, 258);
            EditReservationBtn.Name = "EditReservationBtn";
            EditReservationBtn.Size = new Size(101, 36);
            EditReservationBtn.TabIndex = 27;
            EditReservationBtn.Text = "Edit";
            EditReservationBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(183, 258);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(101, 36);
            CancelBtn.TabIndex = 28;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CancelBtn);
            Controls.Add(EditReservationBtn);
            Controls.Add(ReservationsTable);
            Controls.Add(dateTimePicker2);
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
        private DateTimePicker dateTimePicker2;
        private DataGridView ReservationsTable;
        private Button EditReservationBtn;
        private Button CancelBtn;
    }
}
