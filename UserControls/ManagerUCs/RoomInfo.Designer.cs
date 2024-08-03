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
            CBRoomType.Location = new Point(79, 71);
            CBRoomType.Margin = new Padding(3, 2, 3, 2);
            CBRoomType.Name = "CBRoomType";
            CBRoomType.Size = new Size(277, 23);
            CBRoomType.TabIndex = 0;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(79, 48);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(95, 21);
            lblRoomType.TabIndex = 1;
            lblRoomType.Text = "Room Type";
            // 
            // lblAmenities
            // 
            lblAmenities.AutoSize = true;
            lblAmenities.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmenities.Location = new Point(79, 110);
            lblAmenities.Name = "lblAmenities";
            lblAmenities.Size = new Size(87, 21);
            lblAmenities.TabIndex = 2;
            lblAmenities.Text = "Amenities";
            // 
            // CHBFreeWF
            // 
            CHBFreeWF.AutoSize = true;
            CHBFreeWF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBFreeWF.Location = new Point(79, 133);
            CHBFreeWF.Margin = new Padding(3, 2, 3, 2);
            CHBFreeWF.Name = "CHBFreeWF";
            CHBFreeWF.Size = new Size(96, 23);
            CHBFreeWF.TabIndex = 3;
            CHBFreeWF.Text = "Free Wi-Fi";
            CHBFreeWF.UseVisualStyleBackColor = true;
            // 
            // CHBFreeBF
            // 
            CHBFreeBF.AutoSize = true;
            CHBFreeBF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBFreeBF.Location = new Point(79, 158);
            CHBFreeBF.Margin = new Padding(3, 2, 3, 2);
            CHBFreeBF.Name = "CHBFreeBF";
            CHBFreeBF.Size = new Size(124, 23);
            CHBFreeBF.TabIndex = 4;
            CHBFreeBF.Text = "Free Breakfast";
            CHBFreeBF.UseVisualStyleBackColor = true;
            // 
            // CHBAC
            // 
            CHBAC.AutoSize = true;
            CHBAC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBAC.Location = new Point(79, 182);
            CHBAC.Margin = new Padding(3, 2, 3, 2);
            CHBAC.Name = "CHBAC";
            CHBAC.Size = new Size(138, 23);
            CHBAC.TabIndex = 5;
            CHBAC.Text = "Air Conditioning";
            CHBAC.UseVisualStyleBackColor = true;
            // 
            // CHBLS
            // 
            CHBLS.AutoSize = true;
            CHBLS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBLS.Location = new Point(228, 133);
            CHBLS.Margin = new Padding(3, 2, 3, 2);
            CHBLS.Name = "CHBLS";
            CHBLS.Size = new Size(143, 23);
            CHBLS.TabIndex = 6;
            CHBLS.Text = "Laundry Services";
            CHBLS.UseVisualStyleBackColor = true;
            // 
            // CHBGP
            // 
            CHBGP.AutoSize = true;
            CHBGP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBGP.Location = new Point(228, 158);
            CHBGP.Margin = new Padding(3, 2, 3, 2);
            CHBGP.Name = "CHBGP";
            CHBGP.Size = new Size(123, 23);
            CHBGP.TabIndex = 7;
            CHBGP.Text = "Gym and Pool";
            CHBGP.UseVisualStyleBackColor = true;
            // 
            // CHBPF
            // 
            CHBPF.AutoSize = true;
            CHBPF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CHBPF.Location = new Point(229, 182);
            CHBPF.Margin = new Padding(3, 2, 3, 2);
            CHBPF.Name = "CHBPF";
            CHBPF.Size = new Size(109, 23);
            CHBPF.TabIndex = 8;
            CHBPF.Text = "Pet-Friendly";
            CHBPF.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(79, 219);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(125, 21);
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
            AddRoomBtn.Location = new Point(79, 286);
            AddRoomBtn.Margin = new Padding(3, 2, 3, 2);
            AddRoomBtn.Name = "AddRoomBtn";
            AddRoomBtn.Size = new Size(88, 27);
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
            EditRoomBtn.Location = new Point(186, 286);
            EditRoomBtn.Margin = new Padding(3, 2, 3, 2);
            EditRoomBtn.Name = "EditRoomBtn";
            EditRoomBtn.Size = new Size(88, 27);
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
            DelRoomBtn.Location = new Point(292, 286);
            DelRoomBtn.Margin = new Padding(3, 2, 3, 2);
            DelRoomBtn.Name = "DelRoomBtn";
            DelRoomBtn.Size = new Size(88, 27);
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
            RoomInfoTable.Location = new Point(79, 334);
            RoomInfoTable.Margin = new Padding(3, 2, 3, 2);
            RoomInfoTable.Name = "RoomInfoTable";
            RoomInfoTable.RowHeadersWidth = 51;
            RoomInfoTable.Size = new Size(521, 123);
            RoomInfoTable.TabIndex = 15;
            RoomInfoTable.CellContentClick += RoomInfoTable_CellContentClick;
            RoomInfoTable.SelectionChanged += RoomInfoTable_SelectionChanged;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNo.Location = new Point(406, 48);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(86, 21);
            lblRoomNo.TabIndex = 17;
            lblRoomNo.Text = "Room No.";
            // 
            // NoOfRoomsPicker
            // 
            NoOfRoomsPicker.Location = new Point(406, 133);
            NoOfRoomsPicker.Margin = new Padding(3, 2, 3, 2);
            NoOfRoomsPicker.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NoOfRoomsPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NoOfRoomsPicker.Name = "NoOfRoomsPicker";
            NoOfRoomsPicker.Size = new Size(129, 23);
            NoOfRoomsPicker.TabIndex = 18;
            NoOfRoomsPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNoOfRooms
            // 
            lblNoOfRooms.AutoSize = true;
            lblNoOfRooms.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoOfRooms.Location = new Point(406, 110);
            lblNoOfRooms.Name = "lblNoOfRooms";
            lblNoOfRooms.Size = new Size(105, 21);
            lblNoOfRooms.TabIndex = 19;
            lblNoOfRooms.Text = "№ of Rooms";
            // 
            // txtRoomDesc
            // 
            txtRoomDesc.Location = new Point(265, 242);
            txtRoomDesc.Margin = new Padding(3, 2, 3, 2);
            txtRoomDesc.Name = "txtRoomDesc";
            txtRoomDesc.Size = new Size(335, 23);
            txtRoomDesc.TabIndex = 20;
            // 
            // lblRoomDesc
            // 
            lblRoomDesc.AutoSize = true;
            lblRoomDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomDesc.Location = new Point(265, 219);
            lblRoomDesc.Name = "lblRoomDesc";
            lblRoomDesc.Size = new Size(147, 21);
            lblRoomDesc.TabIndex = 21;
            lblRoomDesc.Text = "Room Description";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Location = new Point(406, 71);
            txtRoomNo.Margin = new Padding(3, 2, 3, 2);
            txtRoomNo.Mask = "000";
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(110, 23);
            txtRoomNo.TabIndex = 23;
            txtRoomNo.ValidatingType = typeof(int);
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(79, 242);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 23);
            txtPrice.TabIndex = 24;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomInfo";
            Size = new Size(654, 481);
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
