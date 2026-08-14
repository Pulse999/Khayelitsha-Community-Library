namespace KhayelitshaLibrary.WinForms.Forms
{
    partial class ReportForm
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
            lblTitle = new Label();
            btnCurrentOverdue = new Button();
            btnLoansPerMember = new Button();
            btnClear = new Button();
            dataGridViewReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(542, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LIBRARY REPORTS";
            // 
            // btnCurrentOverdue
            // 
            btnCurrentOverdue.Location = new Point(396, 157);
            btnCurrentOverdue.Name = "btnCurrentOverdue";
            btnCurrentOverdue.Size = new Size(184, 23);
            btnCurrentOverdue.TabIndex = 1;
            btnCurrentOverdue.Text = "Current / Overdue Loans";
            btnCurrentOverdue.UseVisualStyleBackColor = true;
            btnCurrentOverdue.Click += btnCurrentOverdue_Click;
            // 
            // btnLoansPerMember
            // 
            btnLoansPerMember.Location = new Point(608, 157);
            btnLoansPerMember.Name = "btnLoansPerMember";
            btnLoansPerMember.Size = new Size(126, 23);
            btnLoansPerMember.TabIndex = 2;
            btnLoansPerMember.Text = "Loans Per Member";
            btnLoansPerMember.UseVisualStyleBackColor = true;
            btnLoansPerMember.Click += btnLoansPerMember_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(758, 157);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(281, 288);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(716, 265);
            dataGridViewReport.TabIndex = 4;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 684);
            Controls.Add(dataGridViewReport);
            Controls.Add(btnClear);
            Controls.Add(btnLoansPerMember);
            Controls.Add(btnCurrentOverdue);
            Controls.Add(lblTitle);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCurrentOverdue;
        private Button btnLoansPerMember;
        private Button btnClear;
        private DataGridView dataGridViewReport;
    }
}