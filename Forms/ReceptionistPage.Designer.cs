namespace IOOP_Assignment_Group10_.Forms
{
    partial class ReceptionistPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblIdentityRCP = new Label();
            LOBtn_RCP = new Button();
            checkOutBtn = new Button();
            UpdateProfileBtn_Rec = new Button();
            CheckInBtn = new Button();
            SearchForResBtn = new Button();
            ManageCustomersBtn = new Button();
            pictureBox1 = new PictureBox();
            ReceptionistPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblIdentityRCP);
            panel1.Controls.Add(LOBtn_RCP);
            panel1.Controls.Add(checkOutBtn);
            panel1.Controls.Add(UpdateProfileBtn_Rec);
            panel1.Controls.Add(CheckInBtn);
            panel1.Controls.Add(SearchForResBtn);
            panel1.Controls.Add(ManageCustomersBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 685);
            panel1.TabIndex = 2;
            // 
            // lblIdentityRCP
            // 
            lblIdentityRCP.AutoSize = true;
            lblIdentityRCP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentityRCP.ForeColor = Color.White;
            lblIdentityRCP.Location = new Point(81, 181);
            lblIdentityRCP.Name = "lblIdentityRCP";
            lblIdentityRCP.Size = new Size(0, 23);
            lblIdentityRCP.TabIndex = 8;
            // 
            // LOBtn_RCP
            // 
            LOBtn_RCP.FlatAppearance.BorderSize = 0;
            LOBtn_RCP.FlatStyle = FlatStyle.Flat;
            LOBtn_RCP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LOBtn_RCP.ForeColor = Color.White;
            LOBtn_RCP.Image = Properties.Resources.logout;
            LOBtn_RCP.ImageAlign = ContentAlignment.MiddleLeft;
            LOBtn_RCP.Location = new Point(3, 541);
            LOBtn_RCP.Name = "LOBtn_RCP";
            LOBtn_RCP.Size = new Size(322, 59);
            LOBtn_RCP.TabIndex = 7;
            LOBtn_RCP.Text = " Logout";
            LOBtn_RCP.TextAlign = ContentAlignment.MiddleLeft;
            LOBtn_RCP.TextImageRelation = TextImageRelation.ImageBeforeText;
            LOBtn_RCP.UseVisualStyleBackColor = true;
            LOBtn_RCP.Click += LOBtn_RCP_Click;
            // 
            // checkOutBtn
            // 
            checkOutBtn.FlatAppearance.BorderSize = 0;
            checkOutBtn.FlatStyle = FlatStyle.Flat;
            checkOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutBtn.ForeColor = Color.White;
            checkOutBtn.Image = Properties.Resources.check_out;
            checkOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            checkOutBtn.Location = new Point(3, 411);
            checkOutBtn.Name = "checkOutBtn";
            checkOutBtn.Size = new Size(322, 59);
            checkOutBtn.TabIndex = 5;
            checkOutBtn.Text = " Check-Out Customers";
            checkOutBtn.TextAlign = ContentAlignment.MiddleLeft;
            checkOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkOutBtn.UseVisualStyleBackColor = true;
            checkOutBtn.Click += button5_Click;
            // 
            // UpdateProfileBtn_Rec
            // 
            UpdateProfileBtn_Rec.FlatAppearance.BorderSize = 0;
            UpdateProfileBtn_Rec.FlatStyle = FlatStyle.Flat;
            UpdateProfileBtn_Rec.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateProfileBtn_Rec.ForeColor = Color.White;
            UpdateProfileBtn_Rec.Image = Properties.Resources.update;
            UpdateProfileBtn_Rec.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateProfileBtn_Rec.Location = new Point(3, 476);
            UpdateProfileBtn_Rec.Name = "UpdateProfileBtn_Rec";
            UpdateProfileBtn_Rec.Size = new Size(322, 59);
            UpdateProfileBtn_Rec.TabIndex = 4;
            UpdateProfileBtn_Rec.Text = " Update Profile";
            UpdateProfileBtn_Rec.TextAlign = ContentAlignment.MiddleLeft;
            UpdateProfileBtn_Rec.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateProfileBtn_Rec.UseVisualStyleBackColor = true;
            UpdateProfileBtn_Rec.Click += button4_Click;
            // 
            // CheckInBtn
            // 
            CheckInBtn.FlatAppearance.BorderSize = 0;
            CheckInBtn.FlatStyle = FlatStyle.Flat;
            CheckInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInBtn.ForeColor = Color.White;
            CheckInBtn.Image = Properties.Resources.check_in;
            CheckInBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CheckInBtn.Location = new Point(3, 346);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(322, 59);
            CheckInBtn.TabIndex = 3;
            CheckInBtn.Text = " Check-In Customers";
            CheckInBtn.TextAlign = ContentAlignment.MiddleLeft;
            CheckInBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CheckInBtn.UseVisualStyleBackColor = true;
            CheckInBtn.Click += button3_Click;
            // 
            // SearchForResBtn
            // 
            SearchForResBtn.FlatAppearance.BorderSize = 0;
            SearchForResBtn.FlatStyle = FlatStyle.Flat;
            SearchForResBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchForResBtn.ForeColor = Color.White;
            SearchForResBtn.Image = Properties.Resources.search;
            SearchForResBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchForResBtn.Location = new Point(3, 281);
            SearchForResBtn.Name = "SearchForResBtn";
            SearchForResBtn.Size = new Size(322, 59);
            SearchForResBtn.TabIndex = 2;
            SearchForResBtn.Text = " Search For Reservation\r\n";
            SearchForResBtn.TextAlign = ContentAlignment.MiddleLeft;
            SearchForResBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchForResBtn.UseVisualStyleBackColor = true;
            SearchForResBtn.Click += button2_Click;
            // 
            // ManageCustomersBtn
            // 
            ManageCustomersBtn.FlatAppearance.BorderSize = 0;
            ManageCustomersBtn.FlatStyle = FlatStyle.Flat;
            ManageCustomersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageCustomersBtn.ForeColor = Color.White;
            ManageCustomersBtn.Image = Properties.Resources.user3;
            ManageCustomersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManageCustomersBtn.Location = new Point(3, 216);
            ManageCustomersBtn.Name = "ManageCustomersBtn";
            ManageCustomersBtn.Size = new Size(322, 59);
            ManageCustomersBtn.TabIndex = 1;
            ManageCustomersBtn.Text = " Manage Customers";
            ManageCustomersBtn.TextAlign = ContentAlignment.MiddleLeft;
            ManageCustomersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ManageCustomersBtn.UseVisualStyleBackColor = true;
            ManageCustomersBtn.Click += UAccBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hotel_Logo3;
            pictureBox1.Location = new Point(81, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ReceptionistPanel
            // 
            ReceptionistPanel.Location = new Point(334, 24);
            ReceptionistPanel.Name = "ReceptionistPanel";
            ReceptionistPanel.Size = new Size(748, 641);
            ReceptionistPanel.TabIndex = 3;
            // 
            // ReceptionistPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 685);
            Controls.Add(ReceptionistPanel);
            Controls.Add(panel1);
            Name = "ReceptionistPage";
            Text = "ReceptionistPage";
            Load += ReceptionistPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblIdentityRCP;
        private Button LOBtn_RCP;
        private Button checkOutBtn;
        private Button UpdateProfileBtn_Rec;
        private Button CheckInBtn;
        private Button SearchForResBtn;
        private Button ManageCustomersBtn;
        private PictureBox pictureBox1;
        private Panel ReceptionistPanel;
    }
}