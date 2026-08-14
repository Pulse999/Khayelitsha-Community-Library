namespace KhayelitshaLibrary.WinForms.Forms
{
    partial class MemberForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblJoinDate = new Label();
            dtpJoinDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            MemberIDCol = new DataGridViewTextBoxColumn();
            FirstNameCol = new DataGridViewTextBoxColumn();
            LastNameCol = new DataGridViewTextBoxColumn();
            EmailCol = new DataGridViewTextBoxColumn();
            AgeCol = new DataGridViewTextBoxColumn();
            AddressCol = new DataGridViewTextBoxColumn();
            PhoneCol = new DataGridViewTextBoxColumn();
            JoinCol = new DataGridViewTextBoxColumn();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            btnRefresh = new Button();
            MembersTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberID.Location = new Point(889, 93);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(140, 17);
            lblMemberID.TabIndex = 0;
            lblMemberID.Text = "Search member by ID\r\n";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(1047, 92);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(265, 23);
            txtMemberID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(148, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 17);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(262, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(150, 125);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(81, 17);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(262, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(166, 258);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 17);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(262, 258);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(122, 302);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(109, 17);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(262, 302);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(265, 23);
            txtPhoneNumber.TabIndex = 9;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJoinDate.Location = new Point(156, 344);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(75, 17);
            lblJoinDate.TabIndex = 10;
            lblJoinDate.Text = "Join Date :";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(262, 344);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(200, 23);
            dtpJoinDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(62, 469);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(62, 535);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(58, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(58, 690);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1334, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MemberIDCol, FirstNameCol, LastNameCol, EmailCol, AgeCol, AddressCol, PhoneCol, JoinCol });
            dataGridView1.Location = new Point(262, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1215, 399);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // MemberIDCol
            // 
            MemberIDCol.DataPropertyName = "MemberID";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberIDCol.DefaultCellStyle = dataGridViewCellStyle2;
            MemberIDCol.HeaderText = "MemberID";
            MemberIDCol.Name = "MemberIDCol";
            MemberIDCol.ReadOnly = true;
            // 
            // FirstNameCol
            // 
            FirstNameCol.DataPropertyName = "FirstName";
            FirstNameCol.HeaderText = "FirstName";
            FirstNameCol.Name = "FirstNameCol";
            FirstNameCol.ReadOnly = true;
            // 
            // LastNameCol
            // 
            LastNameCol.DataPropertyName = "LastName";
            LastNameCol.HeaderText = "LastName";
            LastNameCol.Name = "LastNameCol";
            LastNameCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            EmailCol.DataPropertyName = "Email";
            EmailCol.HeaderText = "Email";
            EmailCol.Name = "EmailCol";
            EmailCol.ReadOnly = true;
            // 
            // AgeCol
            // 
            AgeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AgeCol.DataPropertyName = "Age";
            AgeCol.HeaderText = "Age";
            AgeCol.Name = "AgeCol";
            AgeCol.ReadOnly = true;
            AgeCol.Width = 57;
            // 
            // AddressCol
            // 
            AddressCol.DataPropertyName = "Address";
            AddressCol.HeaderText = "Address";
            AddressCol.Name = "AddressCol";
            AddressCol.ReadOnly = true;
            // 
            // PhoneCol
            // 
            PhoneCol.DataPropertyName = "PhoneNumber";
            PhoneCol.HeaderText = "Phone Number";
            PhoneCol.Name = "PhoneCol";
            PhoneCol.ReadOnly = true;
            // 
            // JoinCol
            // 
            JoinCol.DataPropertyName = "JoinDate";
            JoinCol.HeaderText = "Join Date";
            JoinCol.Name = "JoinCol";
            JoinCol.ReadOnly = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(181, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 19;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(191, 213);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 17);
            lblAge.TabIndex = 20;
            lblAge.Text = "Age :";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(262, 213);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(265, 23);
            txtAge.TabIndex = 21;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1334, 124);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(124, 24);
            btnRefresh.TabIndex = 22;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MembersTitle
            // 
            MembersTitle.AutoSize = true;
            MembersTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MembersTitle.Location = new Point(715, 9);
            MembersTitle.Name = "MembersTitle";
            MembersTitle.Size = new Size(164, 25);
            MembersTitle.TabIndex = 23;
            MembersTitle.Text = "Library Members";
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1578, 859);
            Controls.Add(MembersTitle);
            Controls.Add(btnRefresh);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpJoinDate);
            Controls.Add(lblJoinDate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtMemberID);
            Controls.Add(lblMemberID);
            Name = "MemberForm";
            Text = "MemberForm";
            Load += MemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMemberID;
        private TextBox txtMemberID;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblJoinDate;
        private DateTimePicker dtpJoinDate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAge;
        private TextBox txtAge;
        private DataGridViewTextBoxColumn MemberIDCol;
        private DataGridViewTextBoxColumn FirstNameCol;
        private DataGridViewTextBoxColumn LastNameCol;
        private DataGridViewTextBoxColumn EmailCol;
        private DataGridViewTextBoxColumn AgeCol;
        private DataGridViewTextBoxColumn AddressCol;
        private DataGridViewTextBoxColumn PhoneCol;
        private DataGridViewTextBoxColumn JoinCol;
        private Button btnRefresh;
        private Label MembersTitle;
    }
}