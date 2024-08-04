namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class SendReview
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
            lblReview = new Label();
            txtRoomDesc = new TextBox();
            lblRate = new Label();
            Rate1RB = new RadioButton();
            Rate2RB = new RadioButton();
            Rate3RB = new RadioButton();
            Rate4RB = new RadioButton();
            Rate5RB = new RadioButton();
            Reservations2Table = new DataGridView();
            SendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Reservations2Table).BeginInit();
            SuspendLayout();
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReview.Location = new Point(53, 48);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(104, 21);
            lblReview.TabIndex = 22;
            lblReview.Text = "Your Review";
            // 
            // txtRoomDesc
            // 
            txtRoomDesc.Location = new Point(53, 71);
            txtRoomDesc.Margin = new Padding(3, 2, 3, 2);
            txtRoomDesc.Name = "txtRoomDesc";
            txtRoomDesc.Size = new Size(335, 23);
            txtRoomDesc.TabIndex = 23;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(53, 110);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(44, 21);
            lblRate.TabIndex = 24;
            lblRate.Text = "Rate";
            // 
            // Rate1RB
            // 
            Rate1RB.AutoSize = true;
            Rate1RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate1RB.Location = new Point(53, 133);
            Rate1RB.Margin = new Padding(3, 2, 3, 2);
            Rate1RB.Name = "Rate1RB";
            Rate1RB.Size = new Size(66, 23);
            Rate1RB.TabIndex = 25;
            Rate1RB.Text = "1 Star";
            Rate1RB.UseVisualStyleBackColor = true;
            // 
            // Rate2RB
            // 
            Rate2RB.AutoSize = true;
            Rate2RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate2RB.Location = new Point(53, 158);
            Rate2RB.Margin = new Padding(3, 2, 3, 2);
            Rate2RB.Name = "Rate2RB";
            Rate2RB.Size = new Size(72, 23);
            Rate2RB.TabIndex = 26;
            Rate2RB.Text = "2 Stars";
            Rate2RB.UseVisualStyleBackColor = true;
            // 
            // Rate3RB
            // 
            Rate3RB.AutoSize = true;
            Rate3RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate3RB.Location = new Point(53, 182);
            Rate3RB.Margin = new Padding(3, 2, 3, 2);
            Rate3RB.Name = "Rate3RB";
            Rate3RB.Size = new Size(72, 23);
            Rate3RB.TabIndex = 27;
            Rate3RB.Text = "3 Stars";
            Rate3RB.UseVisualStyleBackColor = true;
            // 
            // Rate4RB
            // 
            Rate4RB.AutoSize = true;
            Rate4RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate4RB.Location = new Point(53, 207);
            Rate4RB.Margin = new Padding(3, 2, 3, 2);
            Rate4RB.Name = "Rate4RB";
            Rate4RB.Size = new Size(72, 23);
            Rate4RB.TabIndex = 28;
            Rate4RB.Text = "4 Stars";
            Rate4RB.UseVisualStyleBackColor = true;
            // 
            // Rate5RB
            // 
            Rate5RB.AutoSize = true;
            Rate5RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate5RB.Location = new Point(53, 232);
            Rate5RB.Margin = new Padding(3, 2, 3, 2);
            Rate5RB.Name = "Rate5RB";
            Rate5RB.Size = new Size(72, 23);
            Rate5RB.TabIndex = 29;
            Rate5RB.Text = "5 Stars";
            Rate5RB.UseVisualStyleBackColor = true;
            // 
            // Reservations2Table
            // 
            Reservations2Table.BackgroundColor = Color.White;
            Reservations2Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Reservations2Table.GridColor = Color.Black;
            Reservations2Table.Location = new Point(53, 294);
            Reservations2Table.Margin = new Padding(3, 2, 3, 2);
            Reservations2Table.Name = "Reservations2Table";
            Reservations2Table.RowHeadersWidth = 51;
            Reservations2Table.Size = new Size(464, 120);
            Reservations2Table.TabIndex = 30;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = SystemColors.HotTrack;
            SendBtn.FlatStyle = FlatStyle.Flat;
            SendBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendBtn.ForeColor = SystemColors.HotTrack;
            SendBtn.Location = new Point(53, 439);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(101, 36);
            SendBtn.TabIndex = 31;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // SendReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SendBtn);
            Controls.Add(Reservations2Table);
            Controls.Add(Rate5RB);
            Controls.Add(Rate4RB);
            Controls.Add(Rate3RB);
            Controls.Add(Rate2RB);
            Controls.Add(Rate1RB);
            Controls.Add(lblRate);
            Controls.Add(txtRoomDesc);
            Controls.Add(lblReview);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SendReview";
            Size = new Size(654, 481);
            ((System.ComponentModel.ISupportInitialize)Reservations2Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReview;
        private TextBox txtRoomDesc;
        private Label lblRate;
        private RadioButton Rate1RB;
        private RadioButton Rate2RB;
        private RadioButton Rate3RB;
        private RadioButton Rate4RB;
        private RadioButton Rate5RB;
        private DataGridView Reservations2Table;
        private Button SendBtn;
    }
}
