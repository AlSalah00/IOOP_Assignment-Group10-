namespace IOOP_Assignment_Group10_.Forms
{
    partial class CustomerPage
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
            label1 = new Label();
            Logout3Btn = new Button();
            SendRevBtn = new Button();
            Update3Btn = new Button();
            ManageResBtn = new Button();
            ViewBtn = new Button();
            SearchBtn = new Button();
            pictureBox1 = new PictureBox();
            CustomerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Logout3Btn);
            panel1.Controls.Add(SendRevBtn);
            panel1.Controls.Add(Update3Btn);
            panel1.Controls.Add(ManageResBtn);
            panel1.Controls.Add(ViewBtn);
            panel1.Controls.Add(SearchBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 514);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 136);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 8;
            label1.Text = "Welcome! (user)";
            // 
            // Logout3Btn
            // 
            Logout3Btn.FlatAppearance.BorderSize = 0;
            Logout3Btn.FlatStyle = FlatStyle.Flat;
            Logout3Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout3Btn.ForeColor = Color.White;
            Logout3Btn.Image = Properties.Resources.logout;
            Logout3Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Logout3Btn.Location = new Point(10, 406);
            Logout3Btn.Margin = new Padding(3, 2, 3, 2);
            Logout3Btn.Name = "Logout3Btn";
            Logout3Btn.Size = new Size(274, 44);
            Logout3Btn.TabIndex = 7;
            Logout3Btn.Text = " Logout";
            Logout3Btn.TextAlign = ContentAlignment.MiddleLeft;
            Logout3Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Logout3Btn.UseVisualStyleBackColor = true;
            // 
            // SendRevBtn
            // 
            SendRevBtn.FlatAppearance.BorderSize = 0;
            SendRevBtn.FlatStyle = FlatStyle.Flat;
            SendRevBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendRevBtn.ForeColor = Color.White;
            SendRevBtn.Image = Properties.Resources.rate;
            SendRevBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SendRevBtn.Location = new Point(10, 308);
            SendRevBtn.Margin = new Padding(3, 2, 3, 2);
            SendRevBtn.Name = "SendRevBtn";
            SendRevBtn.Size = new Size(274, 44);
            SendRevBtn.TabIndex = 5;
            SendRevBtn.Text = "Send review ";
            SendRevBtn.TextAlign = ContentAlignment.MiddleLeft;
            SendRevBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SendRevBtn.UseVisualStyleBackColor = true;
            SendRevBtn.Click += SendRevBtn_Click;
            // 
            // Update3Btn
            // 
            Update3Btn.FlatAppearance.BorderSize = 0;
            Update3Btn.FlatStyle = FlatStyle.Flat;
            Update3Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update3Btn.ForeColor = Color.White;
            Update3Btn.Image = Properties.Resources.update2;
            Update3Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Update3Btn.Location = new Point(10, 357);
            Update3Btn.Margin = new Padding(3, 2, 3, 2);
            Update3Btn.Name = "Update3Btn";
            Update3Btn.Size = new Size(274, 44);
            Update3Btn.TabIndex = 4;
            Update3Btn.Text = "Update own profile";
            Update3Btn.TextAlign = ContentAlignment.MiddleLeft;
            Update3Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Update3Btn.UseVisualStyleBackColor = true;
            Update3Btn.Click += Update3Btn_Click;
            // 
            // ManageResBtn
            // 
            ManageResBtn.FlatAppearance.BorderSize = 0;
            ManageResBtn.FlatStyle = FlatStyle.Flat;
            ManageResBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageResBtn.ForeColor = Color.White;
            ManageResBtn.Image = Properties.Resources.reservation;
            ManageResBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManageResBtn.Location = new Point(10, 260);
            ManageResBtn.Margin = new Padding(3, 2, 3, 2);
            ManageResBtn.Name = "ManageResBtn";
            ManageResBtn.Size = new Size(274, 44);
            ManageResBtn.TabIndex = 3;
            ManageResBtn.Text = "Manage reservation ";
            ManageResBtn.TextAlign = ContentAlignment.MiddleLeft;
            ManageResBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ManageResBtn.UseVisualStyleBackColor = true;
            ManageResBtn.Click += ManageResBtn_Click;
            // 
            // ViewBtn
            // 
            ViewBtn.FlatAppearance.BorderSize = 0;
            ViewBtn.FlatStyle = FlatStyle.Flat;
            ViewBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewBtn.ForeColor = Color.White;
            ViewBtn.Image = Properties.Resources.room;
            ViewBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ViewBtn.Location = new Point(10, 211);
            ViewBtn.Margin = new Padding(3, 2, 3, 2);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(274, 44);
            ViewBtn.TabIndex = 2;
            ViewBtn.Text = "View room details";
            ViewBtn.TextAlign = ContentAlignment.MiddleLeft;
            ViewBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Image = Properties.Resources.search1;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(10, 162);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(274, 44);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search for rooms";
            SearchBtn.TextAlign = ContentAlignment.MiddleLeft;
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hotel_Logo3;
            pictureBox1.Location = new Point(71, 18);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Location = new Point(292, 18);
            CustomerPanel.Margin = new Padding(3, 2, 3, 2);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(654, 481);
            CustomerPanel.TabIndex = 2;
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 514);
            Controls.Add(CustomerPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerPage";
            Text = "CustomerPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Logout3Btn;
        private Button SendRevBtn;
        private Button Update3Btn;
        private Button ManageResBtn;
        private Button ViewBtn;
        private Button SearchBtn;
        private PictureBox pictureBox1;
        private Panel CustomerPanel;
    }
}