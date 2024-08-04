namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class CheckOutCUS
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
            ReservationsTBL = new DataGridView();
            CheckOutBtn = new Button();
            lblcheckout = new Label();
            paymentBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).BeginInit();
            SuspendLayout();
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
            // CheckOutBtn
            // 
            CheckOutBtn.BackColor = Color.Red;
            CheckOutBtn.CausesValidation = false;
            CheckOutBtn.FlatAppearance.BorderSize = 0;
            CheckOutBtn.FlatStyle = FlatStyle.Flat;
            CheckOutBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutBtn.ForeColor = Color.White;
            CheckOutBtn.Location = new Point(88, 502);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.Size = new Size(121, 36);
            CheckOutBtn.TabIndex = 28;
            CheckOutBtn.Text = "Check Out";
            CheckOutBtn.UseVisualStyleBackColor = false;
            CheckOutBtn.Click += CheckOutBtn_Click;
            // 
            // lblcheckout
            // 
            lblcheckout.AutoSize = true;
            lblcheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcheckout.Location = new Point(88, 63);
            lblcheckout.Name = "lblcheckout";
            lblcheckout.Size = new Size(212, 28);
            lblcheckout.TabIndex = 30;
            lblcheckout.Text = "Check-out Customers";
            // 
            // paymentBTN
            // 
            paymentBTN.BackColor = Color.Teal;
            paymentBTN.CausesValidation = false;
            paymentBTN.FlatAppearance.BorderSize = 0;
            paymentBTN.FlatStyle = FlatStyle.Flat;
            paymentBTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentBTN.ForeColor = Color.White;
            paymentBTN.Location = new Point(254, 502);
            paymentBTN.Name = "paymentBTN";
            paymentBTN.Size = new Size(129, 36);
            paymentBTN.TabIndex = 31;
            paymentBTN.Text = "Collect";
            paymentBTN.UseVisualStyleBackColor = false;
            paymentBTN.Click += paymentBTN_Click;
            // 
            // CheckOutCUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(paymentBTN);
            Controls.Add(lblcheckout);
            Controls.Add(CheckOutBtn);
            Controls.Add(ReservationsTBL);
            Name = "CheckOutCUS";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReservationsTBL;
        private Button CheckOutBtn;
        private Label lblcheckout;
        private Button paymentBTN;
    }
}
