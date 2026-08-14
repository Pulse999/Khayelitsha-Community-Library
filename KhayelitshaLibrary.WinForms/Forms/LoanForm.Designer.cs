namespace KhayelitshaLibrary.WinForms.Forms
{
    partial class LoanForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbMember = new ComboBox();
            cmbBookCopy = new ComboBox();
            cmbStaff = new ComboBox();
            dtpLoanDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            chkReturned = new CheckBox();
            txtLoanID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            LoanTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Member:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Book Copy:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 119);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Staff:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 149);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Loan Date:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 181);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Due Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 216);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 5;
            label6.Text = "Return Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(727, 42);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 6;
            label7.Text = "Search Loan ID:";
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(280, 50);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(307, 23);
            cmbMember.TabIndex = 7;
            // 
            // cmbBookCopy
            // 
            cmbBookCopy.FormattingEnabled = true;
            cmbBookCopy.Location = new Point(280, 81);
            cmbBookCopy.Name = "cmbBookCopy";
            cmbBookCopy.Size = new Size(307, 23);
            cmbBookCopy.TabIndex = 8;
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(280, 119);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(307, 23);
            cmbStaff.TabIndex = 9;
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(280, 149);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(200, 23);
            dtpLoanDate.TabIndex = 10;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(280, 181);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 11;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(280, 210);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(200, 23);
            dtpReturnDate.TabIndex = 12;
            // 
            // chkReturned
            // 
            chkReturned.AutoSize = true;
            chkReturned.Location = new Point(513, 216);
            chkReturned.Name = "chkReturned";
            chkReturned.Size = new Size(74, 19);
            chkReturned.TabIndex = 13;
            chkReturned.Text = "Returned";
            chkReturned.UseVisualStyleBackColor = true;
            chkReturned.CheckedChanged += chkReturned_CheckedChanged_1;
            // 
            // txtLoanID
            // 
            txtLoanID.Location = new Point(844, 42);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(200, 23);
            txtLoanID.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(106, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(106, 457);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(106, 528);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(106, 593);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1050, 71);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1050, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(280, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 354);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LoanTitle
            // 
            LoanTitle.AutoSize = true;
            LoanTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoanTitle.Location = new Point(548, -2);
            LoanTitle.Name = "LoanTitle";
            LoanTitle.Size = new Size(64, 25);
            LoanTitle.TabIndex = 22;
            LoanTitle.Text = "Loans";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(LoanTitle);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLoanID);
            Controls.Add(chkReturned);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpDueDate);
            Controls.Add(dtpLoanDate);
            Controls.Add(cmbStaff);
            Controls.Add(cmbBookCopy);
            Controls.Add(cmbMember);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbMember;
        private ComboBox cmbBookCopy;
        private ComboBox cmbStaff;
        private DateTimePicker dtpLoanDate;
        private DateTimePicker dtpDueDate;
        private DateTimePicker dtpReturnDate;
        private CheckBox chkReturned;
        private TextBox txtLoanID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnRefresh;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label LoanTitle;
    }
}