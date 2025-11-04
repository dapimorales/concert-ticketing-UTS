namespace concert_ticketing.Forms
{
    partial class FormConcerts
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
            lblPerformer = new Label();
            lblVanue = new Label();
            lblDate = new Label();
            lblPrice = new Label();
            lblCapacity = new Label();
            txtConcertName = new TextBox();
            txtPerformer = new TextBox();
            txtVenue = new TextBox();
            txtDate = new TextBox();
            txtPrice = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvConcerts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(138, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(127, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nama Konser :";
            // 
            // lblPerformer
            // 
            lblPerformer.AutoSize = true;
            lblPerformer.Location = new Point(146, 91);
            lblPerformer.Name = "lblPerformer";
            lblPerformer.Size = new Size(99, 25);
            lblPerformer.TabIndex = 1;
            lblPerformer.Text = "Performer :";
            // 
            // lblVanue
            // 
            lblVanue.AutoSize = true;
            lblVanue.Location = new Point(164, 141);
            lblVanue.Name = "lblVanue";
            lblVanue.Size = new Size(69, 25);
            lblVanue.TabIndex = 2;
            lblVanue.Text = "Vanue :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(138, 197);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(82, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Tanggal :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(138, 248);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Harga :";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(138, 307);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(95, 25);
            lblCapacity.TabIndex = 5;
            lblCapacity.Text = "Kapasitas :";
            // 
            // txtConcertName
            // 
            txtConcertName.Location = new Point(329, 37);
            txtConcertName.Name = "txtConcertName";
            txtConcertName.Size = new Size(254, 31);
            txtConcertName.TabIndex = 6;
            // 
            // txtPerformer
            // 
            txtPerformer.Location = new Point(329, 95);
            txtPerformer.Name = "txtPerformer";
            txtPerformer.Size = new Size(254, 31);
            txtPerformer.TabIndex = 7;
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(329, 141);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(254, 31);
            txtVenue.TabIndex = 8;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(322, 197);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(254, 31);
            txtDate.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(314, 248);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(264, 31);
            txtPrice.TabIndex = 10;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(309, 304);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(274, 31);
            txtCapacity.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(163, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(355, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(544, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(714, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvConcerts
            // 
            dgvConcerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcerts.Location = new Point(-1, 408);
            dgvConcerts.Name = "dgvConcerts";
            dgvConcerts.RowHeadersWidth = 62;
            dgvConcerts.Size = new Size(1002, 258);
            dgvConcerts.TabIndex = 16;
            // 
            // FormConcerts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 665);
            Controls.Add(dgvConcerts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(txtDate);
            Controls.Add(txtVenue);
            Controls.Add(txtPerformer);
            Controls.Add(txtConcertName);
            Controls.Add(lblCapacity);
            Controls.Add(lblPrice);
            Controls.Add(lblDate);
            Controls.Add(lblVanue);
            Controls.Add(lblPerformer);
            Controls.Add(lblName);
            Name = "FormConcerts";
            Text = "FormConcerts";
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPerformer;
        private Label lblVanue;
        private Label lblDate;
        private Label lblPrice;
        private Label lblCapacity;
        private TextBox txtConcertName;
        private TextBox txtPerformer;
        private TextBox txtVenue;
        private TextBox txtDate;
        private TextBox txtPrice;
        private TextBox txtCapacity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvConcerts;
    }
}