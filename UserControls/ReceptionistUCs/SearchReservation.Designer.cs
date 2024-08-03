namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class SearchReservation
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
            SearchBTN = new Button();
            ReservationsTBL = new DataGridView();
            txtResID = new TextBox();
            lblPayable = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).BeginInit();
            SuspendLayout();
            // 
            // SearchBTN
            // 
            SearchBTN.BackColor = SystemColors.HotTrack;
            SearchBTN.FlatAppearance.BorderSize = 0;
            SearchBTN.FlatStyle = FlatStyle.Flat;
            SearchBTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBTN.ForeColor = Color.White;
            SearchBTN.Location = new Point(88, 502);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(101, 36);
            SearchBTN.TabIndex = 13;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = false;
            SearchBTN.Click += SearchBTN_Click;
            // 
            // ReservationsTBL
            // 
            ReservationsTBL.BackgroundColor = Color.White;
            ReservationsTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTBL.GridColor = Color.Black;
            ReservationsTBL.Location = new Point(88, 264);
            ReservationsTBL.Name = "ReservationsTBL";
            ReservationsTBL.RowHeadersWidth = 51;
            ReservationsTBL.Size = new Size(571, 160);
            ReservationsTBL.TabIndex = 27;
            // 
            // txtResID
            // 
            txtResID.Location = new Point(272, 150);
            txtResID.Name = "txtResID";
            txtResID.Size = new Size(209, 27);
            txtResID.TabIndex = 28;
            // 
            // lblPayable
            // 
            lblPayable.AutoSize = true;
            lblPayable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayable.Location = new Point(95, 146);
            lblPayable.Name = "lblPayable";
            lblPayable.Size = new Size(146, 28);
            lblPayable.TabIndex = 30;
            lblPayable.Text = "ReservationID";
            lblPayable.Click += lblPayable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 39);
            label1.Name = "label1";
            label1.Size = new Size(313, 28);
            label1.TabIndex = 31;
            label1.Text = "Search for existing reservations";
            // 
            // SearchReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(lblPayable);
            Controls.Add(txtResID);
            Controls.Add(ReservationsTBL);
            Controls.Add(SearchBTN);
            Name = "SearchReservation";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBTN;
        private DataGridView ReservationsTBL;
        private TextBox txtResID;
        private Label lblPayable;
        private Label label1;
    }
}
