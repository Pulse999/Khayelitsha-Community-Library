namespace KhayelitshaLibrary.WinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblLearnerDetails = new Label();
            btnMembers = new Button();
            btnBooks = new Button();
            btnLoansReturns = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(228, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(494, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "KHAYELITSHA COMMUNITY LIBRARY";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLearnerDetails
            // 
            lblLearnerDetails.AutoSize = true;
            lblLearnerDetails.Font = new Font("Castellar", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLearnerDetails.Location = new Point(421, 544);
            lblLearnerDetails.Name = "lblLearnerDetails";
            lblLearnerDetails.Size = new Size(143, 54);
            lblLearnerDetails.TabIndex = 1;
            lblLearnerDetails.Text = "Developed By\r\nThemba Kene\r\n20240439\r\n";
            // 
            // btnMembers
            // 
            btnMembers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembers.Location = new Point(302, 164);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(180, 60);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(482, 164);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(180, 60);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnLoansReturns
            // 
            btnLoansReturns.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoansReturns.Location = new Point(302, 291);
            btnLoansReturns.Name = "btnLoansReturns";
            btnLoansReturns.Size = new Size(180, 60);
            btnLoansReturns.TabIndex = 4;
            btnLoansReturns.Text = " Loans / Returns";
            btnLoansReturns.UseVisualStyleBackColor = true;
            btnLoansReturns.Click += btnLoansReturns_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(482, 291);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 60);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1013, 597);
            Controls.Add(btnReports);
            Controls.Add(btnLoansReturns);
            Controls.Add(btnBooks);
            Controls.Add(btnMembers);
            Controls.Add(lblLearnerDetails);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khayelitsha Community Library";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLearnerDetails;
        private Button btnMembers;
        private Button btnBooks;
        private Button btnLoansReturns;
        private Button btnReports;
    }
}
