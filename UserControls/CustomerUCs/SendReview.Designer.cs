﻿namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
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
            txtReview = new TextBox();
            lblRate = new Label();
            Rate1RB = new RadioButton();
            Rate2RB = new RadioButton();
            Rate3RB = new RadioButton();
            Rate4RB = new RadioButton();
            Rate5RB = new RadioButton();
            ReservationsTable = new DataGridView();
            SendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReview.Location = new Point(61, 64);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(128, 28);
            lblReview.TabIndex = 22;
            lblReview.Text = "Your Review";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(61, 95);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(382, 27);
            txtReview.TabIndex = 23;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(61, 147);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(55, 28);
            lblRate.TabIndex = 24;
            lblRate.Text = "Rate";
            // 
            // Rate1RB
            // 
            Rate1RB.AutoSize = true;
            Rate1RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate1RB.Location = new Point(61, 177);
            Rate1RB.Name = "Rate1RB";
            Rate1RB.Size = new Size(79, 27);
            Rate1RB.TabIndex = 25;
            Rate1RB.Text = "1 Star";
            Rate1RB.UseVisualStyleBackColor = true;
            // 
            // Rate2RB
            // 
            Rate2RB.AutoSize = true;
            Rate2RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate2RB.Location = new Point(61, 211);
            Rate2RB.Name = "Rate2RB";
            Rate2RB.Size = new Size(86, 27);
            Rate2RB.TabIndex = 26;
            Rate2RB.Text = "2 Stars";
            Rate2RB.UseVisualStyleBackColor = true;
            // 
            // Rate3RB
            // 
            Rate3RB.AutoSize = true;
            Rate3RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate3RB.Location = new Point(61, 243);
            Rate3RB.Name = "Rate3RB";
            Rate3RB.Size = new Size(86, 27);
            Rate3RB.TabIndex = 27;
            Rate3RB.Text = "3 Stars";
            Rate3RB.UseVisualStyleBackColor = true;
            // 
            // Rate4RB
            // 
            Rate4RB.AutoSize = true;
            Rate4RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate4RB.Location = new Point(61, 276);
            Rate4RB.Name = "Rate4RB";
            Rate4RB.Size = new Size(86, 27);
            Rate4RB.TabIndex = 28;
            Rate4RB.Text = "4 Stars";
            Rate4RB.UseVisualStyleBackColor = true;
            // 
            // Rate5RB
            // 
            Rate5RB.AutoSize = true;
            Rate5RB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate5RB.Location = new Point(61, 309);
            Rate5RB.Name = "Rate5RB";
            Rate5RB.Size = new Size(86, 27);
            Rate5RB.TabIndex = 29;
            Rate5RB.Text = "5 Stars";
            Rate5RB.UseVisualStyleBackColor = true;
            // 
            // ReservationsTable
            // 
            ReservationsTable.BackgroundColor = Color.White;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTable.GridColor = Color.Black;
            ReservationsTable.Location = new Point(61, 377);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersWidth = 51;
            ReservationsTable.Size = new Size(530, 160);
            ReservationsTable.TabIndex = 30;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = SystemColors.HotTrack;
            SendBtn.FlatAppearance.BorderSize = 0;
            SendBtn.FlatStyle = FlatStyle.Flat;
            SendBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.ForeColor = Color.White;
            SendBtn.Location = new Point(61, 572);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(101, 36);
            SendBtn.TabIndex = 31;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click_1;
            // 
            // SendReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SendBtn);
            Controls.Add(ReservationsTable);
            Controls.Add(Rate5RB);
            Controls.Add(Rate4RB);
            Controls.Add(Rate3RB);
            Controls.Add(Rate2RB);
            Controls.Add(Rate1RB);
            Controls.Add(lblRate);
            Controls.Add(txtReview);
            Controls.Add(lblReview);
            Name = "SendReview";
            Size = new Size(747, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReview;
        private TextBox txtReview;
        private Label lblRate;
        private RadioButton Rate1RB;
        private RadioButton Rate2RB;
        private RadioButton Rate3RB;
        private RadioButton Rate4RB;
        private RadioButton Rate5RB;
        private DataGridView ReservationsTable;
        private Button SendBtn;
    }
}
