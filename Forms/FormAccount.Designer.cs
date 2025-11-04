namespace concert_ticketing.Forms
{
    partial class FormAccount
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
            lblName = new Label();
            txtFullName = new TextBox();
            btnAdd = new Button();
            lblEmail = new Label();
            lblPhone = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvAccounts = new DataGridView();
            txtAddress = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(85, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nama :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(194, 28);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(218, 31);
            txtFullName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(104, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(85, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(85, 174);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(194, 174);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(218, 31);
            txtPhoneNumber.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(347, 326);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(548, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(775, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(-12, 394);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 62;
            dgvAccounts.Size = new Size(1122, 352);
            dgvAccounts.TabIndex = 10;
            dgvAccounts.CellClick += DgvAccounts_CellDoubleClick;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(194, 251);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 31);
            txtAddress.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 251);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 11;
            label1.Text = "Address :";
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 647);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(dgvAccounts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(btnAdd);
            Controls.Add(txtFullName);
            Controls.Add(lblName);
            Name = "FormAccount";
            Text = "FormAccount";
            Load += FormAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtFullName;
        private Button btnAdd;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvAccounts;
        private TextBox txtAddress;
        private Label label1;
    }
}