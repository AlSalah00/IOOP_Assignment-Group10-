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
            AddRoomBtn = new Button();
            EditRoomBtn = new Button();
            DelRoomBtn = new Button();
            RoomInfoTable = new DataGridView();
            lblRoomNo = new Label();
            NoOfRoomsPicker = new NumericUpDown();
            lblNoOfRooms = new Label();
            txtRoomDesc = new TextBox();
            lblRoomDesc = new Label();
            txtRoomNo = new MaskedTextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RoomInfoTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoOfRoomsPicker).BeginInit();
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
            lblPrice.Size = new Size(156, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price per Night";
            // 
            // AddRoomBtn
            // 
            AddRoomBtn.BackColor = SystemColors.HotTrack;
            AddRoomBtn.FlatAppearance.BorderSize = 0;
            AddRoomBtn.FlatStyle = FlatStyle.Flat;
            AddRoomBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddRoomBtn.ForeColor = Color.White;
            AddRoomBtn.Location = new Point(90, 382);
            AddRoomBtn.Name = "AddRoomBtn";
            AddRoomBtn.Size = new Size(101, 36);
            AddRoomBtn.TabIndex = 12;
            AddRoomBtn.Text = "Add";
            AddRoomBtn.UseVisualStyleBackColor = false;
            AddRoomBtn.Click += AddRoomBtn_Click;
            // 
            // EditRoomBtn
            // 
            EditRoomBtn.BackColor = SystemColors.HotTrack;
            EditRoomBtn.FlatAppearance.BorderSize = 0;
            EditRoomBtn.FlatStyle = FlatStyle.Flat;
            EditRoomBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditRoomBtn.ForeColor = Color.White;
            EditRoomBtn.Location = new Point(212, 382);
            EditRoomBtn.Name = "EditRoomBtn";
            EditRoomBtn.Size = new Size(101, 36);
            EditRoomBtn.TabIndex = 13;
            EditRoomBtn.Text = "Edit";
            EditRoomBtn.UseVisualStyleBackColor = false;
            EditRoomBtn.Click += EditRoomBtn_Click;
            // 
            // DelRoomBtn
            // 
            DelRoomBtn.BackColor = Color.Red;
            DelRoomBtn.FlatAppearance.BorderSize = 0;
            DelRoomBtn.FlatStyle = FlatStyle.Flat;
            DelRoomBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelRoomBtn.ForeColor = Color.White;
            DelRoomBtn.Location = new Point(334, 382);
            DelRoomBtn.Name = "DelRoomBtn";
            DelRoomBtn.Size = new Size(101, 36);
            DelRoomBtn.TabIndex = 14;
            DelRoomBtn.Text = "Delete";
            DelRoomBtn.UseVisualStyleBackColor = false;
            DelRoomBtn.Click += DelRoomBtn_Click;
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
            RoomInfoTable.SelectionChanged += RoomInfoTable_SelectionChanged;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNo.Location = new Point(464, 64);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(106, 28);
            lblRoomNo.TabIndex = 17;
            lblRoomNo.Text = "Room No.";
            // 
            // NoOfRoomsPicker
            // 
            NoOfRoomsPicker.Location = new Point(464, 177);
            NoOfRoomsPicker.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NoOfRoomsPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NoOfRoomsPicker.Name = "NoOfRoomsPicker";
            NoOfRoomsPicker.Size = new Size(147, 27);
            NoOfRoomsPicker.TabIndex = 18;
            NoOfRoomsPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNoOfRooms
            // 
            lblNoOfRooms.AutoSize = true;
            lblNoOfRooms.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoOfRooms.Location = new Point(464, 146);
            lblNoOfRooms.Name = "lblNoOfRooms";
            lblNoOfRooms.Size = new Size(132, 28);
            lblNoOfRooms.TabIndex = 19;
            lblNoOfRooms.Text = "№ of Rooms";
            // 
            // txtRoomDesc
            // 
            txtRoomDesc.Location = new Point(303, 323);
            txtRoomDesc.Name = "txtRoomDesc";
            txtRoomDesc.Size = new Size(382, 27);
            txtRoomDesc.TabIndex = 20;
            // 
            // lblRoomDesc
            // 
            lblRoomDesc.AutoSize = true;
            lblRoomDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomDesc.Location = new Point(303, 292);
            lblRoomDesc.Name = "lblRoomDesc";
            lblRoomDesc.Size = new Size(182, 28);
            lblRoomDesc.TabIndex = 21;
            lblRoomDesc.Text = "Room Description";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Location = new Point(464, 95);
            txtRoomNo.Mask = "000";
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(125, 27);
            txtRoomNo.TabIndex = 23;
            txtRoomNo.ValidatingType = typeof(int);
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 323);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(156, 27);
            txtPrice.TabIndex = 24;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPrice);
            Controls.Add(txtRoomNo);
            Controls.Add(lblRoomDesc);
            Controls.Add(txtRoomDesc);
            Controls.Add(lblNoOfRooms);
            Controls.Add(NoOfRoomsPicker);
            Controls.Add(lblRoomNo);
            Controls.Add(RoomInfoTable);
            Controls.Add(DelRoomBtn);
            Controls.Add(EditRoomBtn);
            Controls.Add(AddRoomBtn);
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
            ((System.ComponentModel.ISupportInitialize)NoOfRoomsPicker).EndInit();
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
        private Button AddRoomBtn;
        private Button EditRoomBtn;
        private Button DelRoomBtn;
        private DataGridView RoomInfoTable;
        private Label lblRoomNo;
        private NumericUpDown NoOfRoomsPicker;
        private Label lblNoOfRooms;
        private TextBox txtRoomDesc;
        private Label lblRoomDesc;
        private MaskedTextBox txtRoomNo;
        private TextBox txtPrice;
    }
}
