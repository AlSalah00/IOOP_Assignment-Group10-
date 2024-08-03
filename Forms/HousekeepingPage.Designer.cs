namespace IOOP_Assignment_Group10_.Forms
{
    partial class HousekeepingPage
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
            lblIdentityHK = new Label();
            LOBtn_HK = new Button();
            ClnSuppsBtn = new Button();
            UpdateProfileHKBtn = new Button();
            RoomClnsBtn = new Button();
            URRBtn = new Button();
            RoomCSCHBtn = new Button();
            pictureBox1 = new PictureBox();
            HousekeepingPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblIdentityHK);
            panel1.Controls.Add(LOBtn_HK);
            panel1.Controls.Add(ClnSuppsBtn);
            panel1.Controls.Add(UpdateProfileHKBtn);
            panel1.Controls.Add(RoomClnsBtn);
            panel1.Controls.Add(URRBtn);
            panel1.Controls.Add(RoomCSCHBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 685);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // lblIdentityHK
            // 
            lblIdentityHK.AutoSize = true;
            lblIdentityHK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentityHK.ForeColor = Color.White;
            lblIdentityHK.Location = new Point(81, 181);
            lblIdentityHK.Name = "lblIdentityHK";
            lblIdentityHK.Size = new Size(0, 23);
            lblIdentityHK.TabIndex = 8;
            // 
            // LOBtn_HK
            // 
            LOBtn_HK.FlatAppearance.BorderSize = 0;
            LOBtn_HK.FlatStyle = FlatStyle.Flat;
            LOBtn_HK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LOBtn_HK.ForeColor = Color.White;
            LOBtn_HK.Image = Properties.Resources.logout;
            LOBtn_HK.ImageAlign = ContentAlignment.MiddleLeft;
            LOBtn_HK.Location = new Point(3, 541);
            LOBtn_HK.Name = "LOBtn_HK";
            LOBtn_HK.Size = new Size(322, 59);
            LOBtn_HK.TabIndex = 7;
            LOBtn_HK.Text = " Logout";
            LOBtn_HK.TextAlign = ContentAlignment.MiddleLeft;
            LOBtn_HK.TextImageRelation = TextImageRelation.ImageBeforeText;
            LOBtn_HK.UseVisualStyleBackColor = true;
            LOBtn_HK.Click += LOBtn_HK_Click;
            // 
            // ClnSuppsBtn
            // 
            ClnSuppsBtn.FlatAppearance.BorderSize = 0;
            ClnSuppsBtn.FlatStyle = FlatStyle.Flat;
            ClnSuppsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClnSuppsBtn.ForeColor = Color.White;
            ClnSuppsBtn.Image = Properties.Resources.cleaning;
            ClnSuppsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClnSuppsBtn.Location = new Point(3, 411);
            ClnSuppsBtn.Name = "ClnSuppsBtn";
            ClnSuppsBtn.Size = new Size(322, 59);
            ClnSuppsBtn.TabIndex = 5;
            ClnSuppsBtn.Text = "Cleaning Supplies";
            ClnSuppsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ClnSuppsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ClnSuppsBtn.UseVisualStyleBackColor = true;
            ClnSuppsBtn.Click += ClnSuppsBtn_Click;
            // 
            // UpdateProfileHKBtn
            // 
            UpdateProfileHKBtn.FlatAppearance.BorderSize = 0;
            UpdateProfileHKBtn.FlatStyle = FlatStyle.Flat;
            UpdateProfileHKBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateProfileHKBtn.ForeColor = Color.White;
            UpdateProfileHKBtn.Image = Properties.Resources.update3;
            UpdateProfileHKBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateProfileHKBtn.Location = new Point(3, 476);
            UpdateProfileHKBtn.Name = "UpdateProfileHKBtn";
            UpdateProfileHKBtn.Size = new Size(322, 59);
            UpdateProfileHKBtn.TabIndex = 4;
            UpdateProfileHKBtn.Text = " Update Profile";
            UpdateProfileHKBtn.TextAlign = ContentAlignment.MiddleLeft;
            UpdateProfileHKBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateProfileHKBtn.UseVisualStyleBackColor = true;
            UpdateProfileHKBtn.Click += UpdateProfileHKBtn_Click;
            // 
            // RoomClnsBtn
            // 
            RoomClnsBtn.FlatAppearance.BorderSize = 0;
            RoomClnsBtn.FlatStyle = FlatStyle.Flat;
            RoomClnsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomClnsBtn.ForeColor = Color.White;
            RoomClnsBtn.Image = Properties.Resources.mop;
            RoomClnsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RoomClnsBtn.Location = new Point(3, 346);
            RoomClnsBtn.Name = "RoomClnsBtn";
            RoomClnsBtn.Size = new Size(322, 59);
            RoomClnsBtn.TabIndex = 3;
            RoomClnsBtn.Text = "Room Cleanliness";
            RoomClnsBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomClnsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            RoomClnsBtn.UseVisualStyleBackColor = true;
            RoomClnsBtn.Click += RoomClnsBtn_Click;
            // 
            // URRBtn
            // 
            URRBtn.FlatAppearance.BorderSize = 0;
            URRBtn.FlatStyle = FlatStyle.Flat;
            URRBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            URRBtn.ForeColor = Color.White;
            URRBtn.Image = Properties.Resources.reservations;
            URRBtn.ImageAlign = ContentAlignment.MiddleLeft;
            URRBtn.Location = new Point(3, 281);
            URRBtn.Name = "URRBtn";
            URRBtn.Size = new Size(322, 59);
            URRBtn.TabIndex = 2;
            URRBtn.Text = " Upcoming Room Reservations";
            URRBtn.TextAlign = ContentAlignment.MiddleLeft;
            URRBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            URRBtn.UseVisualStyleBackColor = true;
            URRBtn.Click += URRBtn_Click;
            // 
            // RoomCSCHBtn
            // 
            RoomCSCHBtn.FlatAppearance.BorderSize = 0;
            RoomCSCHBtn.FlatStyle = FlatStyle.Flat;
            RoomCSCHBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomCSCHBtn.ForeColor = Color.White;
            RoomCSCHBtn.Image = Properties.Resources.schedule;
            RoomCSCHBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RoomCSCHBtn.Location = new Point(3, 216);
            RoomCSCHBtn.Name = "RoomCSCHBtn";
            RoomCSCHBtn.Size = new Size(322, 59);
            RoomCSCHBtn.TabIndex = 1;
            RoomCSCHBtn.Text = " Room cleaning Schedule";
            RoomCSCHBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomCSCHBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            RoomCSCHBtn.UseVisualStyleBackColor = true;
            RoomCSCHBtn.Click += RoomCSCHBtn_Click;
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
            // HousekeepingPanel
            // 
            HousekeepingPanel.Location = new Point(334, 24);
            HousekeepingPanel.Name = "HousekeepingPanel";
            HousekeepingPanel.Size = new Size(748, 641);
            HousekeepingPanel.TabIndex = 4;
            // 
            // HousekeepingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 685);
            Controls.Add(HousekeepingPanel);
            Controls.Add(panel1);
            Name = "HousekeepingPage";
            Text = "HousekeepingPage";
            Load += HousekeepingPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblIdentityHK;
        private Button LOBtn_HK;
        private Button ClnSuppsBtn;
        private Button UpdateProfileHKBtn;
        private Button RoomClnsBtn;
        private Button URRBtn;
        private Button RoomCSCHBtn;
        private PictureBox pictureBox1;
        private Panel HousekeepingPanel;
    }
}