using ConcertTicketing.Models;
using ConcertTicketing.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace concert_ticketing.Forms
{
    public partial class FormAccount : Form
    {
        private readonly AccountService _accountService;
        private int? selectedAccountId = null;

        public FormAccount(AccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;

            // Pastikan event terdaftar dengan benar
            this.Load += FormAccount_Load;
            dgvAccounts.CellDoubleClick += DgvAccounts_CellDoubleClick;
        }

        // 🔹 Load data awal
        private void FormAccount_Load(object sender, EventArgs e)
        {
            dgvAccounts.ReadOnly = true;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.MultiSelect = false;

            LoadAccounts();
        }

        // 🔹 Load semua data akun
        private void LoadAccounts()
        {
            try
            {
                var accounts = _accountService.GetAll();

                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = accounts;

                // Sesuaikan header
                if (dgvAccounts.Columns["Id"] != null)
                    dgvAccounts.Columns["Id"].HeaderText = "ID";
                if (dgvAccounts.Columns["FullName"] != null)
                    dgvAccounts.Columns["FullName"].HeaderText = "Nama Lengkap";
                if (dgvAccounts.Columns["Email"] != null)
                    dgvAccounts.Columns["Email"].HeaderText = "Email";
                if (dgvAccounts.Columns["PhoneNumber"] != null)
                    dgvAccounts.Columns["PhoneNumber"].HeaderText = "Nomor HP";
                if (dgvAccounts.Columns["Address"] != null)
                    dgvAccounts.Columns["Address"].HeaderText = "Alamat";

                // Sembunyikan navigasi EF
                if (dgvAccounts.Columns["Tickets"] != null)
                    dgvAccounts.Columns["Tickets"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data akun: " + ex.Message);
            }
        }

        // 🔹 Double click row → isi textbox
        private void DgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAccounts.Rows.Count > 0)
            {
                var row = dgvAccounts.Rows[e.RowIndex];
                if (row.DataBoundItem is Account selectedAccount)
                {
                    selectedAccountId = selectedAccount.Id;
                    txtFullName.Text = selectedAccount.FullName;
                    txtEmail.Text = selectedAccount.Email;
                    txtPhoneNumber.Text = selectedAccount.PhoneNumber;
                    txtAddress.Text = selectedAccount.Address;
                }
            }
        }

        // 🔹 Tambah akun
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Nama dan Email wajib diisi!");
                    return;
                }

                var account = new Account
                {
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _accountService.Add(account);
                MessageBox.Show("Akun berhasil ditambahkan!");
                LoadAccounts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah akun: " + ex.Message);
            }
        }

        // 🔹 Update akun
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccountId == null)
                {
                    MessageBox.Show("⚠️ Pilih dulu akun yang mau diupdate (double-click di tabel).");
                    return;
                }

                var account = new Account
                {
                    Id = selectedAccountId.Value,
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _accountService.Update(account);
                MessageBox.Show("✅ Data akun berhasil diperbarui!");
                LoadAccounts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update akun: " + ex.Message);
            }
        }

        // 🔹 Hapus akun
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccountId == null)
                {
                    MessageBox.Show("Silakan pilih akun yang ingin dihapus.");
                    return;
                }

                var confirm = MessageBox.Show("Yakin ingin menghapus akun ini?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    _accountService.Delete(selectedAccountId.Value);
                    MessageBox.Show("Akun berhasil dihapus!");
                    LoadAccounts();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus akun: " + ex.Message);
            }
        }

        // 🔹 Clear form
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            selectedAccountId = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
