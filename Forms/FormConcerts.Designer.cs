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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConcerts));
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
            lblName.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(138, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(159, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Nama Konser    :";
            // 
            // lblPerformer
            // 
            lblPerformer.AutoSize = true;
            lblPerformer.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerformer.Location = new Point(138, 87);
            lblPerformer.Name = "lblPerformer";
            lblPerformer.Size = new Size(158, 21);
            lblPerformer.TabIndex = 1;
            lblPerformer.Text = "Performer       :";
            // 
            // lblVanue
            // 
            lblVanue.AutoSize = true;
            lblVanue.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVanue.Location = new Point(138, 138);
            lblVanue.Name = "lblVanue";
            lblVanue.Size = new Size(158, 21);
            lblVanue.TabIndex = 2;
            lblVanue.Text = "Venue                 :";
            lblVanue.Click += lblVanue_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(138, 192);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(158, 21);
            lblDate.TabIndex = 3;
            lblDate.Text = "Tanggal             :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(138, 247);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(156, 21);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Harga                :";
            lblPrice.Click += lblPrice_Click;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacity.Location = new Point(138, 301);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(156, 21);
            lblCapacity.TabIndex = 5;
            lblCapacity.Text = "Kapasitas         :";
            // 
            // txtConcertName
            // 
            txtConcertName.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConcertName.Location = new Point(329, 37);
            txtConcertName.Name = "txtConcertName";
            txtConcertName.Size = new Size(254, 29);
            txtConcertName.TabIndex = 6;
            // 
            // txtPerformer
            // 
            txtPerformer.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPerformer.Location = new Point(329, 87);
            txtPerformer.Name = "txtPerformer";
            txtPerformer.Size = new Size(254, 29);
            txtPerformer.TabIndex = 7;
            // 
            // txtVenue
            // 
            txtVenue.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVenue.Location = new Point(329, 141);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(254, 29);
            txtVenue.TabIndex = 8;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(328, 197);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(254, 29);
            txtDate.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(329, 244);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(254, 29);
            txtPrice.TabIndex = 10;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(328, 304);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(255, 29);
            txtCapacity.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnUpdate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(321, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(687, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(847, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvConcerts
            // 
            dgvConcerts.BackgroundColor = Color.LemonChiffon;
            dgvConcerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcerts.Location = new Point(-1, 408);
            dgvConcerts.Name = "dgvConcerts";
            dgvConcerts.RowHeadersWidth = 62;
            dgvConcerts.Size = new Size(1103, 258);
            dgvConcerts.TabIndex = 16;
            // 
            // FormConcerts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 584);
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