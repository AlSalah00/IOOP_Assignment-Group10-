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
            txtCusName = new TextBox();
            lblCusName = new Label();
            label1 = new Label();
            ReservationsTable = new DataGridView();
            lblRoomNo = new Label();
            txtRoomNum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // SearchBTN
            // 
            SearchBTN.BackColor = SystemColors.HotTrack;
            SearchBTN.FlatAppearance.BorderSize = 0;
            SearchBTN.FlatStyle = FlatStyle.Flat;
            SearchBTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBTN.ForeColor = Color.White;
            SearchBTN.Location = new Point(61, 561);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(101, 36);
            SearchBTN.TabIndex = 13;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = false;
            SearchBTN.Click += SearchBTN_Click;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(61, 177);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(313, 27);
            txtCusName.TabIndex = 28;
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusName.Location = new Point(61, 146);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(300, 28);
            lblCusName.TabIndex = 30;
            lblCusName.Text = "Search by Customer Username";
            lblCusName.Click += lblPayable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 64);
            label1.Name = "label1";
            label1.Size = new Size(313, 28);
            label1.TabIndex = 31;
            label1.Text = "Search for existing reservations";
            // 
            // ReservationsTable
            // 
            ReservationsTable.BackgroundColor = Color.White;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTable.GridColor = Color.Black;
            ReservationsTable.Location = new Point(61, 375);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersWidth = 51;
            ReservationsTable.Size = new Size(530, 160);
            ReservationsTable.TabIndex = 32;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNo.Location = new Point(61, 251);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(204, 28);
            lblRoomNo.TabIndex = 33;
            lblRoomNo.Text = "Search by Room No.";
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(61, 282);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(204, 27);
            txtRoomNum.TabIndex = 34;
            // 
            // SearchReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtRoomNum);
            Controls.Add(lblRoomNo);
            Controls.Add(ReservationsTable);
            Controls.Add(label1);
            Controls.Add(lblCusName);
            Controls.Add(txtCusName);
            Controls.Add(SearchBTN);
            Name = "SearchReservation";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBTN;
        private TextBox txtCusName;
        private Label lblCusName;
        private Label label1;
        private DataGridView ReservationsTable;
        private Label lblRoomNo;
        private TextBox txtRoomNum;
    }
}
