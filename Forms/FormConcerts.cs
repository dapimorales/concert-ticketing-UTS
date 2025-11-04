using ConcertTicketing.Models;
using ConcertTicketing.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace concert_ticketing.Forms
{
    public partial class FormConcerts : Form
    {
        private readonly ConcertService _concertService;
        private int? selectedConcertId = null;

        public FormConcerts(ConcertService concertService)
        {
            InitializeComponent();
            _concertService = concertService;

            // Pastikan event Load terhubung
            this.Load += FormConcerts_Load;

            // Pastikan event double click terdaftar
            dgvConcerts.CellDoubleClick += DgvConcerts_CellDoubleClick;
        }

        private void FormConcerts_Load(object sender, EventArgs e)
        {
            dgvConcerts.ReadOnly = true;
            dgvConcerts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConcerts.MultiSelect = false;
            dgvConcerts.AutoGenerateColumns = true; // Penting!

            LoadConcerts();
        }

        private void LoadConcerts()
        {
            try
            {
                List<Concert> concerts = _concertService.GetAll();
                dgvConcerts.DataSource = null;
                dgvConcerts.DataSource = concerts;

                // Atur header kolom
                if (dgvConcerts.Columns["Id"] != null)
                    dgvConcerts.Columns["Id"].HeaderText = "ID";
                if (dgvConcerts.Columns["ConcertName"] != null)
                    dgvConcerts.Columns["ConcertName"].HeaderText = "Nama Konser";
                if (dgvConcerts.Columns["Performer"] != null)
                    dgvConcerts.Columns["Performer"].HeaderText = "Artis / Performer";
                if (dgvConcerts.Columns["Venue"] != null)
                    dgvConcerts.Columns["Venue"].HeaderText = "Tempat";
                if (dgvConcerts.Columns["ConcertDate"] != null)
                    dgvConcerts.Columns["ConcertDate"].HeaderText = "Tanggal";
                if (dgvConcerts.Columns["TicketPrice"] != null)
                    dgvConcerts.Columns["TicketPrice"].HeaderText = "Harga Tiket";
                if (dgvConcerts.Columns["Capacity"] != null)
                    dgvConcerts.Columns["Capacity"].HeaderText = "Kapasitas";

                if (dgvConcerts.Columns["Tickets"] != null)
                    dgvConcerts.Columns["Tickets"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data konser: " + ex.Message);
            }
        }

        // Double click untuk edit
        private void DgvConcerts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvConcerts.Rows[e.RowIndex].DataBoundItem is Concert selectedConcert)
            {
                selectedConcertId = selectedConcert.Id;
                txtConcertName.Text = selectedConcert.ConcertName;
                txtPerformer.Text = selectedConcert.Performer;
                txtVenue.Text = selectedConcert.Venue;
                txtDate.Text = selectedConcert.ConcertDate.ToString("yyyy-MM-dd");
                txtPrice.Text = selectedConcert.TicketPrice.ToString();
                txtCapacity.Text = selectedConcert.Capacity.ToString();
            }
        }

        // Tambah konser
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var parsedDate = DateTime.ParseExact(
                    txtDate.Text,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture
                );

                var concert = new Concert
                {
                    ConcertName = txtConcertName.Text.Trim(),
                    Performer = txtPerformer.Text.Trim(),
                    Venue = txtVenue.Text.Trim(),
                    ConcertDate = DateTime.SpecifyKind(parsedDate, DateTimeKind.Utc),
                    TicketPrice = decimal.Parse(txtPrice.Text),
                    Capacity = int.Parse(txtCapacity.Text)
                };

                _concertService.Add(concert);
                MessageBox.Show("Konser berhasil ditambahkan!");
                LoadConcerts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah konser: " +
                    (ex.InnerException?.Message ?? ex.Message));
            }
        }



        // Update konser
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedConcertId == null)
            {
                MessageBox.Show("Pilih konser yang ingin diupdate (double-click di tabel).");
                return;
            }

            try
            {
                // Membuat objek BARU yang berisi data form (ini OK, karena Service akan me-replace datanya)
                var concert = new Concert
                {
                    Id = selectedConcertId.Value,
                    ConcertName = txtConcertName.Text.Trim(),
                    Performer = txtPerformer.Text.Trim(),
                    Venue = txtVenue.Text.Trim(),
                    ConcertDate = DateTime.Parse(txtDate.Text),
                    TicketPrice = decimal.Parse(txtPrice.Text),
                    Capacity = int.Parse(txtCapacity.Text)
                };

                // Memanggil service. Service akan menemukan entitas lama dan meng-overwrite propertinya.
                _concertService.Update(concert);

                MessageBox.Show("Data konser berhasil diperbarui!");
                LoadConcerts();
                ClearForm();
            }
            catch (KeyNotFoundException knfe)
            {
                MessageBox.Show("Error: " + knfe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate konser: " + ex.Message);
            }
        }

        // Delete konser
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedConcertId == null)
            {
                MessageBox.Show("Pilih konser yang ingin dihapus.");
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus konser ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _concertService.Delete(selectedConcertId.Value);
                    MessageBox.Show("Konser berhasil dihapus!");
                    LoadConcerts();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus konser: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtConcertName.Clear();
            txtPerformer.Clear();
            txtVenue.Clear();
            txtDate.Clear();
            txtPrice.Clear();
            txtCapacity.Clear();
            selectedConcertId = null;
        }
    }
}
