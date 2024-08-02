namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class ManageCustomers
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
            UsersTable = new DataGridView();
            txtPassword = new MaskedTextBox();
            DelUserBtn = new Button();
            AddUserBtn = new Button();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)UsersTable).BeginInit();
            SuspendLayout();
            // 
            // UsersTable
            // 
            UsersTable.BackgroundColor = Color.White;
            UsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTable.GridColor = Color.Black;
            UsersTable.Location = new Point(89, 389);
            UsersTable.Name = "UsersTable";
            UsersTable.RowHeadersWidth = 51;
            UsersTable.Size = new Size(571, 160);
            UsersTable.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(316, 27);
            txtPassword.TabIndex = 24;
            // 
            // DelUserBtn
            // 
            DelUserBtn.BackColor = Color.Red;
            DelUserBtn.FlatAppearance.BorderSize = 0;
            DelUserBtn.FlatStyle = FlatStyle.Flat;
            DelUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelUserBtn.ForeColor = Color.White;
            DelUserBtn.Location = new Point(210, 325);
            DelUserBtn.Name = "DelUserBtn";
            DelUserBtn.Size = new Size(101, 36);
            DelUserBtn.TabIndex = 23;
            DelUserBtn.Text = "Delete";
            DelUserBtn.UseVisualStyleBackColor = false;
            DelUserBtn.Click += DelUserBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = SystemColors.HotTrack;
            AddUserBtn.FlatAppearance.BorderSize = 0;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(89, 325);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(101, 36);
            AddUserBtn.TabIndex = 22;
            AddUserBtn.Text = "Add";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(89, 75);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(316, 27);
            txtUserName.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(89, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(89, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(89, 44);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(UsersTable);
            Controls.Add(txtPassword);
            Controls.Add(DelUserBtn);
            Controls.Add(AddUserBtn);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Name = "ManageCustomers";
            Size = new Size(748, 641);
            Load += ManageCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)UsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UsersTable;
        private MaskedTextBox txtPassword;
        private Button DelUserBtn;
        private Button AddUserBtn;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblUsername;
        private TextBox textBox1;
        private Label label1;
        private Label lblPhoneNumber;
    }
}
