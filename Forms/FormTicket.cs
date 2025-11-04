using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcertTicketing.Data;
using ConcertTicketing.Models;
using ConcertTicketing.Services;

namespace concert_ticketing.Forms
{
    public partial class FormTicket : Form
    {
        private readonly ConcertTicketContext _context;

        public FormTicket()
        {
            InitializeComponent();
            _context = new ConcertTicketContext();
            LoadComboboxes();
            LoadTickets();
        }

        private void LoadComboboxes()
        {
            // Load daftar akun (jika hanya user, tampilkan semua user)
            cbAccount.DataSource = _context.Accounts.ToList();
            cbAccount.DisplayMember = "Username";
            cbAccount.ValueMember = "Id";

            // Load daftar konser
            cbConcert.DataSource = _context.Concerts.ToList();
            cbConcert.DisplayMember = "ConcertName";
            cbConcert.ValueMember = "Id";
        }

        private void LoadTickets()
        {
            var data = _context.Tickets
                .Select(t => new
                {
                    t.Id,
                    t.TicketNumber,
                    Account = t.Account.FullName,
                    Concert = t.Concert.ConcertName,
                    t.SeatNumber,
                    t.PricePaid,
                    t.PurchaseDate
                })
                .ToList();

            dgvTickets.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var ticket = new Ticket
                {
                    TicketNumber = txtTicketNumber.Text,
                    SeatNumber = txtSeatNumber.Text,
                    PricePaid = decimal.Parse(txtPricePaid.Text),
                    PurchaseDate = dtpPurchaseDate.Value,
                    AccountId = (int)cbAccount.SelectedValue,
                    ConcertId = (int)cbConcert.SelectedValue
                };

                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                MessageBox.Show("Ticket added successfully!");
                ClearForm();
                LoadTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding ticket: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Select a ticket to update.");
                return;
            }

            int id = (int)dgvTickets.CurrentRow.Cells["Id"].Value;
            var ticket = _context.Tickets.Find(id);

            if (ticket != null)
            {
                ticket.TicketNumber = txtTicketNumber.Text;
                ticket.SeatNumber = txtSeatNumber.Text;
                ticket.PricePaid = decimal.Parse(txtPricePaid.Text);
                ticket.PurchaseDate = dtpPurchaseDate.Value;
                ticket.AccountId = (int)cbAccount.SelectedValue;
                ticket.ConcertId = (int)cbConcert.SelectedValue;

                _context.SaveChanges();
                MessageBox.Show("Ticket updated successfully!");
                ClearForm();
                LoadTickets();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Select a ticket to delete.");
                return;
            }

            int id = (int)dgvTickets.CurrentRow.Cells["Id"].Value;
            var ticket = _context.Tickets.Find(id);

            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
                MessageBox.Show("Ticket deleted successfully!");
                ClearForm();
                LoadTickets();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTicketNumber.Clear();
            txtSeatNumber.Clear();
            txtPricePaid.Clear();
            dtpPurchaseDate.Value = DateTime.Now;
            cbAccount.SelectedIndex = -1;
            cbConcert.SelectedIndex = -1;
        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTicketNumber.Text = dgvTickets.Rows[e.RowIndex].Cells["TicketNumber"].Value?.ToString();
                txtSeatNumber.Text = dgvTickets.Rows[e.RowIndex].Cells["SeatNumber"].Value?.ToString();
                txtPricePaid.Text = dgvTickets.Rows[e.RowIndex].Cells["PricePaid"].Value?.ToString();
                dtpPurchaseDate.Value = Convert.ToDateTime(dgvTickets.Rows[e.RowIndex].Cells["PurchaseDate"].Value);
            }
        }
    }
}
