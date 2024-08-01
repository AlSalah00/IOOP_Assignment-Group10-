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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            UAccBtn = new Button();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(UAccBtn);
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
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.cleaning;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 411);
            button5.Name = "button5";
            button5.Size = new Size(322, 59);
            button5.TabIndex = 5;
            button5.Text = "Cleaning Supplies";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.update3;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 476);
            button4.Name = "button4";
            button4.Size = new Size(322, 59);
            button4.TabIndex = 4;
            button4.Text = " Update Profile";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.mop;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 346);
            button3.Name = "button3";
            button3.Size = new Size(322, 59);
            button3.TabIndex = 3;
            button3.Text = "Room Cleanliness";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.reservations;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 281);
            button2.Name = "button2";
            button2.Size = new Size(322, 59);
            button2.TabIndex = 2;
            button2.Text = " Upcoming Room Reservations";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // UAccBtn
            // 
            UAccBtn.FlatAppearance.BorderSize = 0;
            UAccBtn.FlatStyle = FlatStyle.Flat;
            UAccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UAccBtn.ForeColor = Color.White;
            UAccBtn.Image = Properties.Resources.schedule;
            UAccBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UAccBtn.Location = new Point(3, 216);
            UAccBtn.Name = "UAccBtn";
            UAccBtn.Size = new Size(322, 59);
            UAccBtn.TabIndex = 1;
            UAccBtn.Text = " Room cleaning Schedule";
            UAccBtn.TextAlign = ContentAlignment.MiddleLeft;
            UAccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UAccBtn.UseVisualStyleBackColor = true;
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
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button UAccBtn;
        private PictureBox pictureBox1;
        private Panel HousekeepingPanel;
    }
}