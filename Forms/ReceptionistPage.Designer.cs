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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
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
            LOBtn_RCP.Location = new Point(12, 541);
            LOBtn_RCP.Name = "LOBtn_RCP";
            LOBtn_RCP.Size = new Size(313, 59);
            LOBtn_RCP.TabIndex = 7;
            LOBtn_RCP.Text = " Logout";
            LOBtn_RCP.TextAlign = ContentAlignment.MiddleLeft;
            LOBtn_RCP.TextImageRelation = TextImageRelation.ImageBeforeText;
            LOBtn_RCP.UseVisualStyleBackColor = true;
            LOBtn_RCP.Click += LOBtn_RCP_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 411);
            button5.Name = "button5";
            button5.Size = new Size(313, 59);
            button5.TabIndex = 5;
            button5.Text = "Check-Out Customers";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(12, 476);
            button4.Name = "button4";
            button4.Size = new Size(313, 59);
            button4.TabIndex = 4;
            button4.Text = "Update Own Profile";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 346);
            button3.Name = "button3";
            button3.Size = new Size(313, 59);
            button3.TabIndex = 3;
            button3.Text = "Check-In Customers";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 281);
            button2.Name = "button2";
            button2.Size = new Size(313, 59);
            button2.TabIndex = 2;
            button2.Text = "Search For Reservation\r\n";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ManageCustomersBtn
            // 
            ManageCustomersBtn.FlatAppearance.BorderSize = 0;
            ManageCustomersBtn.FlatStyle = FlatStyle.Flat;
            ManageCustomersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageCustomersBtn.ForeColor = Color.White;
            ManageCustomersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManageCustomersBtn.Location = new Point(12, 216);
            ManageCustomersBtn.Name = "ManageCustomersBtn";
            ManageCustomersBtn.Size = new Size(313, 59);
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
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button ManageCustomersBtn;
        private PictureBox pictureBox1;
        private Panel ReceptionistPanel;
    }
}