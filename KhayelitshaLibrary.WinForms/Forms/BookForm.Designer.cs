namespace KhayelitshaLibrary.WinForms.Forms
{
    partial class BookForm
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
            lblBookTitleID = new Label();
            txtBookTitleID = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridViewBooks = new DataGridView();
            Title = new Label();
            DataTitle = new Label();
            lblCopyID = new Label();
            lblCopyBookTitle = new Label();
            lblCopyStatus = new Label();
            txtCopyID = new TextBox();
            cmbCopyBookTitle = new ComboBox();
            cmbCopyStatus = new ComboBox();
            PhysicalTilte = new Label();
            btnAddCopy = new Button();
            btnClearCopy = new Button();
            btnDeleteCopy = new Button();
            btnUpdateCopy = new Button();
            BookCopiesTitle = new Label();
            dataGridViewCopies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopies).BeginInit();
            SuspendLayout();
            // 
            // lblBookTitleID
            // 
            lblBookTitleID.AutoSize = true;
            lblBookTitleID.Location = new Point(91, 39);
            lblBookTitleID.Name = "lblBookTitleID";
            lblBookTitleID.Size = new Size(77, 15);
            lblBookTitleID.TabIndex = 0;
            lblBookTitleID.Text = "Book Title ID:";
            // 
            // txtBookTitleID
            // 
            txtBookTitleID.Location = new Point(209, 36);
            txtBookTitleID.Name = "txtBookTitleID";
            txtBookTitleID.Size = new Size(131, 23);
            txtBookTitleID.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(135, 68);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(209, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(248, 23);
            txtTitle.TabIndex = 3;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(121, 102);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(209, 99);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(248, 23);
            txtAuthor.TabIndex = 5;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(133, 134);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(35, 15);
            lblISBN.TabIndex = 6;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(209, 134);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(248, 23);
            txtISBN.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(110, 164);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(209, 164);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(248, 23);
            txtCategory.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(287, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(398, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(509, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(626, 225);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(168, 296);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(705, 114);
            dataGridViewBooks.TabIndex = 14;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(436, 8);
            Title.Name = "Title";
            Title.Size = new Size(182, 25);
            Title.TabIndex = 15;
            Title.Text = "Book Managemnet";
            // 
            // DataTitle
            // 
            DataTitle.AutoSize = true;
            DataTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataTitle.Location = new Point(464, 268);
            DataTitle.Name = "DataTitle";
            DataTitle.Size = new Size(110, 25);
            DataTitle.TabIndex = 16;
            DataTitle.Text = "Book Titles";
            // 
            // lblCopyID
            // 
            lblCopyID.AutoSize = true;
            lblCopyID.Location = new Point(128, 457);
            lblCopyID.Name = "lblCopyID";
            lblCopyID.Size = new Size(52, 15);
            lblCopyID.TabIndex = 17;
            lblCopyID.Text = "Copy ID:";
            // 
            // lblCopyBookTitle
            // 
            lblCopyBookTitle.AutoSize = true;
            lblCopyBookTitle.Location = new Point(117, 487);
            lblCopyBookTitle.Name = "lblCopyBookTitle";
            lblCopyBookTitle.Size = new Size(63, 15);
            lblCopyBookTitle.TabIndex = 18;
            lblCopyBookTitle.Text = "Book Title:";
            // 
            // lblCopyStatus
            // 
            lblCopyStatus.AutoSize = true;
            lblCopyStatus.Location = new Point(138, 522);
            lblCopyStatus.Name = "lblCopyStatus";
            lblCopyStatus.Size = new Size(42, 15);
            lblCopyStatus.TabIndex = 19;
            lblCopyStatus.Text = "Status:";
            // 
            // txtCopyID
            // 
            txtCopyID.Location = new Point(186, 449);
            txtCopyID.Name = "txtCopyID";
            txtCopyID.Size = new Size(154, 23);
            txtCopyID.TabIndex = 20;
            // 
            // cmbCopyBookTitle
            // 
            cmbCopyBookTitle.FormattingEnabled = true;
            cmbCopyBookTitle.Location = new Point(186, 484);
            cmbCopyBookTitle.Name = "cmbCopyBookTitle";
            cmbCopyBookTitle.Size = new Size(213, 23);
            cmbCopyBookTitle.TabIndex = 21;
            // 
            // cmbCopyStatus
            // 
            cmbCopyStatus.FormattingEnabled = true;
            cmbCopyStatus.Location = new Point(186, 522);
            cmbCopyStatus.Name = "cmbCopyStatus";
            cmbCopyStatus.Size = new Size(213, 23);
            cmbCopyStatus.TabIndex = 22;
            // 
            // PhysicalTilte
            // 
            PhysicalTilte.AutoSize = true;
            PhysicalTilte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhysicalTilte.Location = new Point(436, 425);
            PhysicalTilte.Name = "PhysicalTilte";
            PhysicalTilte.Size = new Size(230, 25);
            PhysicalTilte.TabIndex = 23;
            PhysicalTilte.Text = "PHYSICAL BOOK COPIES";
            // 
            // btnAddCopy
            // 
            btnAddCopy.Location = new Point(287, 574);
            btnAddCopy.Name = "btnAddCopy";
            btnAddCopy.Size = new Size(75, 23);
            btnAddCopy.TabIndex = 24;
            btnAddCopy.Text = "Add Copy";
            btnAddCopy.UseVisualStyleBackColor = true;
            btnAddCopy.Click += btnAddCopy_Click;
            // 
            // btnClearCopy
            // 
            btnClearCopy.Location = new Point(626, 574);
            btnClearCopy.Name = "btnClearCopy";
            btnClearCopy.Size = new Size(75, 23);
            btnClearCopy.TabIndex = 25;
            btnClearCopy.Text = "Clear";
            btnClearCopy.UseVisualStyleBackColor = true;
            btnClearCopy.Click += btnClearCopy_Click;
            // 
            // btnDeleteCopy
            // 
            btnDeleteCopy.Location = new Point(499, 574);
            btnDeleteCopy.Name = "btnDeleteCopy";
            btnDeleteCopy.Size = new Size(98, 23);
            btnDeleteCopy.TabIndex = 26;
            btnDeleteCopy.Text = "Delete Copy";
            btnDeleteCopy.UseVisualStyleBackColor = true;
            btnDeleteCopy.Click += btnDeleteCopy_Click;
            // 
            // btnUpdateCopy
            // 
            btnUpdateCopy.Location = new Point(398, 574);
            btnUpdateCopy.Name = "btnUpdateCopy";
            btnUpdateCopy.Size = new Size(75, 23);
            btnUpdateCopy.TabIndex = 27;
            btnUpdateCopy.Text = "Update Copy";
            btnUpdateCopy.UseVisualStyleBackColor = true;
            btnUpdateCopy.Click += btnUpdateCopy_Click;
            // 
            // BookCopiesTitle
            // 
            BookCopiesTitle.AutoSize = true;
            BookCopiesTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookCopiesTitle.Location = new Point(440, 632);
            BookCopiesTitle.Name = "BookCopiesTitle";
            BookCopiesTitle.Size = new Size(134, 25);
            BookCopiesTitle.TabIndex = 29;
            BookCopiesTitle.Text = "BOOK COPIES";
            // 
            // dataGridViewCopies
            // 
            dataGridViewCopies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCopies.Location = new Point(168, 675);
            dataGridViewCopies.Name = "dataGridViewCopies";
            dataGridViewCopies.Size = new Size(705, 150);
            dataGridViewCopies.TabIndex = 30;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 862);
            Controls.Add(dataGridViewCopies);
            Controls.Add(BookCopiesTitle);
            Controls.Add(btnUpdateCopy);
            Controls.Add(btnDeleteCopy);
            Controls.Add(btnClearCopy);
            Controls.Add(btnAddCopy);
            Controls.Add(PhysicalTilte);
            Controls.Add(cmbCopyStatus);
            Controls.Add(cmbCopyBookTitle);
            Controls.Add(txtCopyID);
            Controls.Add(lblCopyStatus);
            Controls.Add(lblCopyBookTitle);
            Controls.Add(lblCopyID);
            Controls.Add(DataTitle);
            Controls.Add(Title);
            Controls.Add(dataGridViewBooks);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtBookTitleID);
            Controls.Add(lblBookTitleID);
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Management";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitleID;
        private TextBox txtBookTitleID;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblCategory;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridViewBooks;
        private Label Title;
        private Label DataTitle;
        private Label lblCopyID;
        private Label lblCopyBookTitle;
        private Label lblCopyStatus;
        private TextBox txtCopyID;
        private ComboBox cmbCopyBookTitle;
        private ComboBox cmbCopyStatus;
        private Label PhysicalTilte;
        private Button btnAddCopy;
        private Button btnClearCopy;
        private Button btnDeleteCopy;
        private Button btnUpdateCopy;
        private Label BookCopiesTitle;
        private DataGridView dataGridViewCopies;
    }
}