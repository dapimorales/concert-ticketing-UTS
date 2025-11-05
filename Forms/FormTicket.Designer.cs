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
            lblAccount.Location = new Point(73, 39);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(86, 25);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account :";
            // 
            // lblConcert
            // 
            lblConcert.AutoSize = true;
            lblConcert.Location = new Point(73, 105);
            lblConcert.Name = "lblConcert";
            lblConcert.Size = new Size(82, 25);
            lblConcert.TabIndex = 1;
            lblConcert.Text = "Concert :";
            // 
            // lblTicketNumber
            // 
            lblTicketNumber.AutoSize = true;
            lblTicketNumber.Location = new Point(73, 173);
            lblTicketNumber.Name = "lblTicketNumber";
            lblTicketNumber.Size = new Size(95, 25);
            lblTicketNumber.TabIndex = 2;
            lblTicketNumber.Text = "Ticket No :";
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Location = new Point(73, 246);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(55, 25);
            lblSeat.TabIndex = 3;
            lblSeat.Text = "Seat :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(91, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(289, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(498, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(696, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbAccount
            // 
            cbAccount.FormattingEnabled = true;
            cbAccount.Location = new Point(184, 37);
            cbAccount.Name = "cbAccount";
            cbAccount.Size = new Size(216, 33);
            cbAccount.TabIndex = 8;
            cbAccount.SelectedIndexChanged += cbAccount_SelectedIndexChanged;
            // 
            // cbConcert
            // 
            cbConcert.FormattingEnabled = true;
            cbConcert.Location = new Point(184, 97);
            cbConcert.Name = "cbConcert";
            cbConcert.Size = new Size(216, 33);
            cbConcert.TabIndex = 9;
            cbConcert.SelectedIndexChanged += cbConcert_SelectedIndexChanged;
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Location = new Point(187, 246);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(227, 31);
            txtSeatNumber.TabIndex = 11;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(0, 469);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 62;
            dgvTickets.Size = new Size(1229, 280);
            dgvTickets.TabIndex = 12;
            dgvTickets.CellClick += dgvTickets_CellClick;
            dgvTickets.CellContentDoubleClick += dgvTickets_CellClick;
            // 
            // txtTicketNumber
            // 
            txtTicketNumber.Location = new Point(187, 170);
            txtTicketNumber.Name = "txtTicketNumber";
            txtTicketNumber.Size = new Size(214, 31);
            txtTicketNumber.TabIndex = 13;
            // 
            // txtPricePaid
            // 
            txtPricePaid.Location = new Point(187, 303);
            txtPricePaid.Name = "txtPricePaid";
            txtPricePaid.Size = new Size(227, 31);
            txtPricePaid.TabIndex = 15;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(73, 303);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(96, 25);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price Paid :";
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Location = new Point(73, 359);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(133, 25);
            lblPurchaseDate.TabIndex = 16;
            lblPurchaseDate.Text = "Purchase Date :";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(212, 353);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(300, 31);
            dtpPurchaseDate.TabIndex = 17;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 750);
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