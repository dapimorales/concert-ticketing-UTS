namespace concert_ticketing.Forms
{
    partial class FormTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            lblAccount = new Label();
            lblConcert = new Label();
            lblTicketNumber = new Label();
            lblSeat = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            cbAccount = new ComboBox();
            cbConcert = new ComboBox();
            txtSeatNumber = new TextBox();
            dgvTickets = new DataGridView();
            txtTicketNumber = new TextBox();
            txtPricePaid = new TextBox();
            lblPrice = new Label();
            lblPurchaseDate = new Label();
            dtpPurchaseDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(73, 39);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(155, 21);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account            :";
            // 
            // lblConcert
            // 
            lblConcert.AutoSize = true;
            lblConcert.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConcert.Location = new Point(73, 105);
            lblConcert.Name = "lblConcert";
            lblConcert.Size = new Size(156, 21);
            lblConcert.TabIndex = 1;
            lblConcert.Text = "Concert            :";
            // 
            // lblTicketNumber
            // 
            lblTicketNumber.AutoSize = true;
            lblTicketNumber.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketNumber.Location = new Point(73, 173);
            lblTicketNumber.Name = "lblTicketNumber";
            lblTicketNumber.Size = new Size(158, 21);
            lblTicketNumber.TabIndex = 2;
            lblTicketNumber.Text = "Ticket No          :";
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeat.Location = new Point(73, 234);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(159, 21);
            lblSeat.TabIndex = 3;
            lblSeat.Text = "Seat                    :";
            lblSeat.Click += lblSeat_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(91, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(279, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(661, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(841, 418);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // cbAccount
            // 
            cbAccount.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAccount.FormattingEnabled = true;
            cbAccount.Location = new Point(256, 32);
            cbAccount.Name = "cbAccount";
            cbAccount.Size = new Size(300, 29);
            cbAccount.TabIndex = 8;
            cbAccount.SelectedIndexChanged += cbAccount_SelectedIndexChanged;
            // 
            // cbConcert
            // 
            cbConcert.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbConcert.FormattingEnabled = true;
            cbConcert.Location = new Point(256, 98);
            cbConcert.Name = "cbConcert";
            cbConcert.Size = new Size(300, 29);
            cbConcert.TabIndex = 9;
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeatNumber.Location = new Point(256, 227);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(300, 29);
            txtSeatNumber.TabIndex = 11;
            // 
            // dgvTickets
            // 
            dgvTickets.BackgroundColor = Color.LemonChiffon;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(0, 469);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 62;
            dgvTickets.Size = new Size(1107, 280);
            dgvTickets.TabIndex = 12;
            dgvTickets.CellContentClick += dgvTickets_CellClick;
            dgvTickets.CellContentDoubleClick += dgvTickets_CellClick;
            // 
            // txtTicketNumber
            // 
            txtTicketNumber.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTicketNumber.Location = new Point(256, 166);
            txtTicketNumber.Name = "txtTicketNumber";
            txtTicketNumber.Size = new Size(300, 29);
            txtTicketNumber.TabIndex = 13;
            // 
            // txtPricePaid
            // 
            txtPricePaid.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPricePaid.Location = new Point(256, 288);
            txtPricePaid.Name = "txtPricePaid";
            txtPricePaid.Size = new Size(300, 29);
            txtPricePaid.TabIndex = 15;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(73, 295);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(160, 21);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price Paid         :";
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchaseDate.Location = new Point(73, 359);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(164, 21);
            lblPurchaseDate.TabIndex = 16;
            lblPurchaseDate.Text = "Purchase Date :";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPurchaseDate.Location = new Point(256, 353);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(300, 29);
            dtpPurchaseDate.TabIndex = 17;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 584);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(lblPurchaseDate);
            Controls.Add(txtPricePaid);
            Controls.Add(lblPrice);
            Controls.Add(txtTicketNumber);
            Controls.Add(dgvTickets);
            Controls.Add(txtSeatNumber);
            Controls.Add(cbConcert);
            Controls.Add(cbAccount);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblSeat);
            Controls.Add(lblTicketNumber);
            Controls.Add(lblConcert);
            Controls.Add(lblAccount);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Label lblConcert;
        private Label lblTicketNumber;
        private Label lblSeat;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private ComboBox cbAccount;
        private ComboBox cbConcert;
        private NumericUpDown numQty;
        private TextBox txtSeatNumber;
        private DataGridView dgvTickets;
        private TextBox txtTicketNumber;
        private TextBox txtPricePaid;
        private Label lblPrice;
        private Label lblPurchaseDate;
        private DateTimePicker dtpPurchaseDate;
    }
}