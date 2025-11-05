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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
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
            lblName.BackColor = SystemColors.ControlLightLight;
            lblName.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(80, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Nama       :";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(201, 28);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(218, 29);
            txtFullName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lblEmail.BackColor = SystemColors.ControlLightLight;
            lblEmail.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(80, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email      :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.ControlLightLight;
            lblPhone.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(81, 177);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 21);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone     :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(201, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 29);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(202, 174);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(218, 29);
            txtPhoneNumber.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(269, 326);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(694, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(864, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.BackgroundColor = Color.LemonChiffon;
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
            txtAddress.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(204, 241);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 29);
            txtAddress.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 246);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 11;
            label1.Text = "Address  : ";
            label1.Click += label1_Click;
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 584);
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