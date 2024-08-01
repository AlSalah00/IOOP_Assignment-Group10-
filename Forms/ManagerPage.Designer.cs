namespace IOOP_Assignment_Group10_
{
    partial class ManagerPage
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
            lblIdentity = new Label();
            LOBtn_M = new Button();
            PRBtn = new Button();
            ROBtn = new Button();
            CRBtn = new Button();
            RCSBtn = new Button();
            RoomInfBtn = new Button();
            UAccBtn = new Button();
            pictureBox1 = new PictureBox();
            ManagerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblIdentity);
            panel1.Controls.Add(LOBtn_M);
            panel1.Controls.Add(PRBtn);
            panel1.Controls.Add(ROBtn);
            panel1.Controls.Add(CRBtn);
            panel1.Controls.Add(RCSBtn);
            panel1.Controls.Add(RoomInfBtn);
            panel1.Controls.Add(UAccBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 685);
            panel1.TabIndex = 0;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentity.ForeColor = Color.White;
            lblIdentity.Location = new Point(81, 181);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(0, 23);
            lblIdentity.TabIndex = 8;
            // 
            // LOBtn_M
            // 
            LOBtn_M.FlatAppearance.BorderSize = 0;
            LOBtn_M.FlatStyle = FlatStyle.Flat;
            LOBtn_M.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LOBtn_M.ForeColor = Color.White;
            LOBtn_M.Image = Properties.Resources.logout;
            LOBtn_M.ImageAlign = ContentAlignment.MiddleLeft;
            LOBtn_M.Location = new Point(3, 606);
            LOBtn_M.Name = "LOBtn_M";
            LOBtn_M.Size = new Size(322, 59);
            LOBtn_M.TabIndex = 7;
            LOBtn_M.Text = " Logout";
            LOBtn_M.TextAlign = ContentAlignment.MiddleLeft;
            LOBtn_M.TextImageRelation = TextImageRelation.ImageBeforeText;
            LOBtn_M.UseVisualStyleBackColor = true;
            LOBtn_M.Click += LOBtn_M_Click;
            // 
            // PRBtn
            // 
            PRBtn.FlatAppearance.BorderSize = 0;
            PRBtn.FlatStyle = FlatStyle.Flat;
            PRBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PRBtn.ForeColor = Color.White;
            PRBtn.Image = Properties.Resources.report;
            PRBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PRBtn.Location = new Point(3, 541);
            PRBtn.Name = "PRBtn";
            PRBtn.Size = new Size(322, 59);
            PRBtn.TabIndex = 6;
            PRBtn.Text = " Profit Report";
            PRBtn.TextAlign = ContentAlignment.MiddleLeft;
            PRBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            PRBtn.UseVisualStyleBackColor = true;
            PRBtn.Click += PRBtn_Click;
            // 
            // ROBtn
            // 
            ROBtn.FlatAppearance.BorderSize = 0;
            ROBtn.FlatStyle = FlatStyle.Flat;
            ROBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ROBtn.ForeColor = Color.White;
            ROBtn.Image = Properties.Resources.occupied;
            ROBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ROBtn.Location = new Point(3, 411);
            ROBtn.Name = "ROBtn";
            ROBtn.Size = new Size(322, 59);
            ROBtn.TabIndex = 5;
            ROBtn.Text = "   Room Occupancy";
            ROBtn.TextAlign = ContentAlignment.MiddleLeft;
            ROBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ROBtn.UseVisualStyleBackColor = true;
            ROBtn.Click += ROBtn_Click;
            // 
            // CRBtn
            // 
            CRBtn.FlatAppearance.BorderSize = 0;
            CRBtn.FlatStyle = FlatStyle.Flat;
            CRBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CRBtn.ForeColor = Color.White;
            CRBtn.Image = Properties.Resources.review;
            CRBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CRBtn.Location = new Point(3, 476);
            CRBtn.Name = "CRBtn";
            CRBtn.Size = new Size(322, 59);
            CRBtn.TabIndex = 4;
            CRBtn.Text = " Customers Reviews";
            CRBtn.TextAlign = ContentAlignment.MiddleLeft;
            CRBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CRBtn.UseVisualStyleBackColor = true;
            CRBtn.Click += CRBtn_Click;
            // 
            // RCSBtn
            // 
            RCSBtn.FlatAppearance.BorderSize = 0;
            RCSBtn.FlatStyle = FlatStyle.Flat;
            RCSBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RCSBtn.ForeColor = Color.White;
            RCSBtn.Image = Properties.Resources.calendar;
            RCSBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RCSBtn.Location = new Point(3, 346);
            RCSBtn.Name = "RCSBtn";
            RCSBtn.Size = new Size(322, 59);
            RCSBtn.TabIndex = 3;
            RCSBtn.Text = " Room Cleaning Schedule";
            RCSBtn.TextAlign = ContentAlignment.MiddleLeft;
            RCSBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            RCSBtn.UseVisualStyleBackColor = true;
            RCSBtn.Click += RCSBtn_Click;
            // 
            // RoomInfBtn
            // 
            RoomInfBtn.FlatAppearance.BorderSize = 0;
            RoomInfBtn.FlatStyle = FlatStyle.Flat;
            RoomInfBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomInfBtn.ForeColor = Color.White;
            RoomInfBtn.Image = Properties.Resources.bed;
            RoomInfBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RoomInfBtn.Location = new Point(3, 281);
            RoomInfBtn.Name = "RoomInfBtn";
            RoomInfBtn.Size = new Size(322, 59);
            RoomInfBtn.TabIndex = 2;
            RoomInfBtn.Text = " Room Information";
            RoomInfBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomInfBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            RoomInfBtn.UseVisualStyleBackColor = true;
            RoomInfBtn.Click += button2_Click;
            // 
            // UAccBtn
            // 
            UAccBtn.FlatAppearance.BorderSize = 0;
            UAccBtn.FlatStyle = FlatStyle.Flat;
            UAccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UAccBtn.ForeColor = Color.White;
            UAccBtn.Image = Properties.Resources.user21;
            UAccBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UAccBtn.Location = new Point(3, 216);
            UAccBtn.Name = "UAccBtn";
            UAccBtn.Size = new Size(322, 59);
            UAccBtn.TabIndex = 1;
            UAccBtn.Text = " Users Accounts";
            UAccBtn.TextAlign = ContentAlignment.MiddleLeft;
            UAccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UAccBtn.UseVisualStyleBackColor = true;
            UAccBtn.Click += button1_Click;
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
            // ManagerPanel
            // 
            ManagerPanel.Location = new Point(334, 24);
            ManagerPanel.Name = "ManagerPanel";
            ManagerPanel.Size = new Size(748, 641);
            ManagerPanel.TabIndex = 1;
            // 
            // ManagerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 685);
            Controls.Add(ManagerPanel);
            Controls.Add(panel1);
            Name = "ManagerPage";
            Text = "ManagerPage";
            Load += ManagerPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button UAccBtn;
        private Button LOBtn_M;
        private Button PRBtn;
        private Button ROBtn;
        private Button CRBtn;
        private Button RCSBtn;
        private Button RoomInfBtn;
        private Label lblIdentity;
        private Panel ManagerPanel;
    }
}