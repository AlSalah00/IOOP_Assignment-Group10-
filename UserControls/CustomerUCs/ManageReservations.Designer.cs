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
            EditBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(53, 48);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(116, 21);
            lblCheckIn.TabIndex = 21;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOut.Location = new Point(53, 110);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(127, 21);
            lblCheckOut.TabIndex = 22;
            lblCheckOut.Text = "Check-out Date";
            // 
            // CheckInDatePicker
            // 
            CheckInDatePicker.CustomFormat = "dd /MMMM/ yyyy";
            CheckInDatePicker.Format = DateTimePickerFormat.Custom;
            CheckInDatePicker.Location = new Point(53, 71);
            CheckInDatePicker.Margin = new Padding(3, 2, 3, 2);
            CheckInDatePicker.Name = "CheckInDatePicker";
            CheckInDatePicker.Size = new Size(219, 23);
            CheckInDatePicker.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd /MMMM/ yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(53, 133);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // ReservationsTable
            // 
            ReservationsTable.BackgroundColor = Color.White;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTable.GridColor = Color.Black;
            ReservationsTable.Location = new Point(53, 266);
            ReservationsTable.Margin = new Padding(3, 2, 3, 2);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersWidth = 51;
            ReservationsTable.Size = new Size(463, 154);
            ReservationsTable.TabIndex = 26;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(53, 194);
            EditBtn.Margin = new Padding(3, 2, 3, 2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(88, 27);
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
            CancelBtn.Location = new Point(160, 194);
            CancelBtn.Margin = new Padding(3, 2, 3, 2);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(88, 27);
            CancelBtn.TabIndex = 28;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(ReservationsTable);
            Controls.Add(dateTimePicker2);
            Controls.Add(CheckInDatePicker);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageReservations";
            Size = new Size(654, 481);
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
        private Button EditBtn;
        private Button CancelBtn;
    }
}
