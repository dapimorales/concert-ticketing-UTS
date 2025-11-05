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
            // Load daftar akun 
            cbAccount.DataSource = _context.Accounts.ToList();
            cbAccount.DisplayMember = "Username";
            cbAccount.ValueMember = "Id";

            // Load daftar konser
            cbConcert.DataSource = _context.Concerts.ToList();
            cbConcert.DisplayMember = "ConcertName";
            cbConcert.ValueMember = "Id";
        }

        private void cbConcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cek apakah ada item yang benar-benar dipilih dan bukan event saat loading data
            if (cbConcert.SelectedValue != null && cbConcert.SelectedIndex != -1)
            {
                try
                {
                    int concertId = Convert.ToInt32(cbConcert.SelectedValue);
                    var selectedConcert = _context.Concerts.Find(concertId);

                    if (selectedConcert != null)
                    {
                        // Set Harga Tiket ke TextBox PricePaid
                        txtPricePaid.Text = selectedConcert.TicketPrice.ToString();
                    }
                    else
                    {
                        txtPricePaid.Clear();
                    }
                }
                catch (Exception)
                {
                    txtPricePaid.Clear();
                }
            }
            else
            {
                txtPricePaid.Clear();
            }
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
            // validasi input
            if (string.IsNullOrWhiteSpace(txtTicketNumber.Text) ||
                string.IsNullOrWhiteSpace(txtSeatNumber.Text) ||
                cbAccount.SelectedValue == null ||
                cbConcert.SelectedValue == null)
            {
                MessageBox.Show("Mohon lengkapi semua bidang dan pastikan Akun/Konser sudah dipilih.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPricePaid.Text, out decimal pricePaid))
            {
                MessageBox.Show("Harga Bayar harus berupa angka yang valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //  Konversi Local Time menjadi UTC
                DateTime purchaseDateLocal = dtpPurchaseDate.Value;
                DateTime purchaseDateUtc = purchaseDateLocal.ToUniversalTime();

                var ticket = new Ticket
                {
                    TicketNumber = txtTicketNumber.Text,
                    SeatNumber = txtSeatNumber.Text,
                    PricePaid = pricePaid,
                    PurchaseDate = purchaseDateUtc, // Digunakan versi UTC

                    AccountId = Convert.ToInt32(cbAccount.SelectedValue),
                    ConcertId = Convert.ToInt32(cbConcert.SelectedValue)
                };

                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                MessageBox.Show("Ticket added successfully!");
                ClearForm();
                LoadTickets();
            }
            catch (Exception ex)
            {
                // Blok catch 
                string errorMessage = "Gagal menambahkan tiket: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nPenyebab DB (Inner Exception 1): " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                    {
                        errorMessage += "\n\nPenyebab DB (Inner Exception 2): " + ex.InnerException.InnerException.Message;
                    }
                }
                MessageBox.Show(errorMessage, "Error Saat Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Pilih tiket yang ingin diupdate.");
                return;
            }

            // validasi input
            if (cbAccount.SelectedValue == null || cbConcert.SelectedValue == null)
            {
                MessageBox.Show("Akun dan Konser harus dipilih.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPricePaid.Text, out decimal pricePaid))
            {
                MessageBox.Show("Harga Bayar harus berupa angka yang valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         

            try
            {
                // Pastikan ID diambil dengan aman
                int id = (int)dgvTickets.CurrentRow.Cells["Id"].Value;
                var ticket = _context.Tickets.Find(id);

                if (ticket != null)
                {
                    // konfersi lokal jadi utc
                    DateTime purchaseDateLocal = dtpPurchaseDate.Value;
                    DateTime purchaseDateUtc = purchaseDateLocal.ToUniversalTime();

                    // Perbarui properti pada entitas yang dilacak
                    ticket.TicketNumber = txtTicketNumber.Text;
                    ticket.SeatNumber = txtSeatNumber.Text;
                    ticket.PricePaid = pricePaid;
                    ticket.PurchaseDate = purchaseDateUtc; // <-- Sudah di-fix
                    ticket.AccountId = Convert.ToInt32(cbAccount.SelectedValue);
                    ticket.ConcertId = Convert.ToInt32(cbConcert.SelectedValue);

                    _context.SaveChanges();
                    MessageBox.Show("Ticket updated successfully!");
                    ClearForm();
                    LoadTickets();
                }
            }
            catch (Exception ex)
            {
                // Lebih baik menangani error ID retrieval juga di sini
                MessageBox.Show($"Gagal mengupdate tiket: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Select a ticket to delete.");
                return;
            }

            try
            {
                // Pengambilan ID diletakkan di dalam try block
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
                else
                {
                    MessageBox.Show("Tiket tidak ditemukan di database.", "Error Deleting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Tangkap exception (misalnya Foreign Key Constraint yang mencegah penghapusan)
                MessageBox.Show($"Gagal menghapus tiket: {ex.Message}", "Error Deleting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormTicket_Load(object sender, EventArgs e)
        {

        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSeat_Click(object sender, EventArgs e)
        {

        }

        //private void btnUpdate_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
