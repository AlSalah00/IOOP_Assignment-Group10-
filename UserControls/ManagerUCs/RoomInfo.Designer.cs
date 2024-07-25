namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class RoomInfo
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
            CBRoomType = new ComboBox();
            lblRoomType = new Label();
            lblAmenities = new Label();
            CHBFreeWF = new CheckBox();
            CHBFreeBF = new CheckBox();
            CHBAC = new CheckBox();
            CHBLS = new CheckBox();
            CHBGP = new CheckBox();
            CHBPF = new CheckBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            AddBtn = new Button();
            EditBtn = new Button();
            DelBtn = new Button();
            RoomInfoTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RoomInfoTable).BeginInit();
            SuspendLayout();
            // 
            // CBRoomType
            // 
            CBRoomType.FormattingEnabled = true;
            CBRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite", "Apartment" });
            CBRoomType.Location = new Point(90, 95);
            CBRoomType.Name = "CBRoomType";
            CBRoomType.Size = new Size(316, 28);
            CBRoomType.TabIndex = 0;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(90, 64);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(118, 28);
            lblRoomType.TabIndex = 1;
            lblRoomType.Text = "Room Type";
            // 
            // lblAmenities
            // 
            lblAmenities.AutoSize = true;
            lblAmenities.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmenities.Location = new Point(90, 146);
            lblAmenities.Name = "lblAmenities";
            lblAmenities.Size = new Size(107, 28);
            lblAmenities.TabIndex = 2;
            lblAmenities.Text = "Amenities";
            // 
            // CHBFreeWF
            // 
            CHBFreeWF.AutoSize = true;
            CHBFreeWF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBFreeWF.Location = new Point(90, 177);
            CHBFreeWF.Name = "CHBFreeWF";
            CHBFreeWF.Size = new Size(114, 27);
            CHBFreeWF.TabIndex = 3;
            CHBFreeWF.Text = "Free Wi-Fi";
            CHBFreeWF.UseVisualStyleBackColor = true;
            // 
            // CHBFreeBF
            // 
            CHBFreeBF.AutoSize = true;
            CHBFreeBF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBFreeBF.Location = new Point(90, 210);
            CHBFreeBF.Name = "CHBFreeBF";
            CHBFreeBF.Size = new Size(147, 27);
            CHBFreeBF.TabIndex = 4;
            CHBFreeBF.Text = "Free Breakfast";
            CHBFreeBF.UseVisualStyleBackColor = true;
            // 
            // CHBAC
            // 
            CHBAC.AutoSize = true;
            CHBAC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBAC.Location = new Point(90, 243);
            CHBAC.Name = "CHBAC";
            CHBAC.Size = new Size(166, 27);
            CHBAC.TabIndex = 5;
            CHBAC.Text = "Air Conditioning";
            CHBAC.UseVisualStyleBackColor = true;
            // 
            // CHBLS
            // 
            CHBLS.AutoSize = true;
            CHBLS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBLS.Location = new Point(260, 177);
            CHBLS.Name = "CHBLS";
            CHBLS.Size = new Size(168, 27);
            CHBLS.TabIndex = 6;
            CHBLS.Text = "Laundry Services";
            CHBLS.UseVisualStyleBackColor = true;
            // 
            // CHBGP
            // 
            CHBGP.AutoSize = true;
            CHBGP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBGP.Location = new Point(260, 210);
            CHBGP.Name = "CHBGP";
            CHBGP.Size = new Size(143, 27);
            CHBGP.TabIndex = 7;
            CHBGP.Text = "Gym and Pool";
            CHBGP.UseVisualStyleBackColor = true;
            // 
            // CHBPF
            // 
            CHBPF.AutoSize = true;
            CHBPF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBPF.Location = new Point(262, 243);
            CHBPF.Name = "CHBPF";
            CHBPF.Size = new Size(128, 27);
            CHBPF.TabIndex = 8;
            CHBPF.Text = "Pet-Friendly";
            CHBPF.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(90, 292);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 323);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(147, 27);
            txtPrice.TabIndex = 10;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(90, 382);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(101, 36);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(212, 382);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(101, 36);
            EditBtn.TabIndex = 13;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Red;
            DelBtn.FlatAppearance.BorderSize = 0;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(334, 382);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(101, 36);
            DelBtn.TabIndex = 14;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // RoomInfoTable
            // 
            RoomInfoTable.BackgroundColor = Color.White;
            RoomInfoTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomInfoTable.GridColor = Color.Black;
            RoomInfoTable.Location = new Point(90, 445);
            RoomInfoTable.Name = "RoomInfoTable";
            RoomInfoTable.RowHeadersWidth = 51;
            RoomInfoTable.Size = new Size(595, 164);
            RoomInfoTable.TabIndex = 15;
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RoomInfoTable);
            Controls.Add(DelBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(CHBPF);
            Controls.Add(CHBGP);
            Controls.Add(CHBLS);
            Controls.Add(CHBAC);
            Controls.Add(CHBFreeBF);
            Controls.Add(CHBFreeWF);
            Controls.Add(lblAmenities);
            Controls.Add(lblRoomType);
            Controls.Add(CBRoomType);
            Name = "RoomInfo";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)RoomInfoTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBRoomType;
        private Label lblRoomType;
        private Label lblAmenities;
        private CheckBox CHBFreeWF;
        private CheckBox CHBFreeBF;
        private CheckBox CHBAC;
        private CheckBox CHBLS;
        private CheckBox CHBGP;
        private CheckBox CHBPF;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button AddBtn;
        private Button EditBtn;
        private Button DelBtn;
        private DataGridView RoomInfoTable;
    }
}
