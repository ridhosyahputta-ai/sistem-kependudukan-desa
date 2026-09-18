using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormTransaksiSurat : Form
    {
        // Menyimpan no_surat data yang sedang dipilih/diedit dari tabel
        private string noSuratSelected = "";

        public FormTransaksiSurat()
        {
            InitializeComponent();

            // Mendaftarkan Event
            this.Load += new EventHandler(FormTransaksiSurat_Load);
            this.btnSimpan.Click += new EventHandler(btnSimpan_Click);
            this.btnUbah.Click += new EventHandler(btnUbah_Click);
            this.btnHapus.Click += new EventHandler(btnHapus_Click);
            this.btnKeluar.Click += new EventHandler(btnKeluar_Click);
            this.dgvTransaksiSurat.CellClick += new DataGridViewCellEventHandler(dgvTransaksiSurat_CellClick);
        }

        private void FormTransaksiSurat_Load(object sender, EventArgs e)
        {
            dtpTanggalPengajuan.Value = DateTime.Now;

            if (cmbJenisSurat.Items.Count > 0)
                cmbJenisSurat.SelectedIndex = 0;

            TampilkanPreviewNoSurat();
            TampilkanDataSurat();
        }

        // Menampilkan seluruh data pengajuan surat ke dgvTransaksiSurat
        private void TampilkanDataSurat()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    string query = "SELECT no_surat AS 'No. Surat', nik AS 'NIK', nama_warga AS 'Nama Warga', jenis_surat AS 'Jenis Surat', tanggal_pengajuan AS 'Tanggal Pengajuan', status AS 'Status' FROM surat";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTransaksiSurat.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data surat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menampilkan preview no_surat berikutnya (nomor final tetap dihitung ulang saat data disimpan)
        private void TampilkanPreviewNoSurat()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    txtNoSurat.Text = GenerateNoSurat(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat nomor surat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menghasilkan no_surat format 001/SRT/tahun berdasarkan jumlah data surat di tahun berjalan
        private string GenerateNoSurat(MySqlConnection conn)
        {
            int tahunSekarang = DateTime.Now.Year;
            string query = "SELECT COUNT(*) FROM surat WHERE YEAR(tanggal_pengajuan) = @tahun";

            int jumlahData;
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tahun", tahunSekarang);
                jumlahData = Convert.ToInt32(cmd.ExecuteScalar());
            }

            int nomorUrut = jumlahData + 1;
            return nomorUrut.ToString("000") + "/SRT/" + tahunSekarang;
        }

        // Validasi input sebelum disimpan
        private bool ValidasiInput()
        {
            string nik = txtNIK.Text.Trim();

            if (string.IsNullOrWhiteSpace(nik) || string.IsNullOrWhiteSpace(txtNamaWarga.Text) || cmbJenisSurat.SelectedItem == null)
            {
                MessageBox.Show("NIK, Nama Warga, dan Jenis Surat wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nik.Length != 16 || !IsDigitsOnly(nik))
            {
                MessageBox.Show("NIK harus terdiri dari 16 digit angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    // Nomor surat dihitung ulang tepat sebelum insert agar mengikuti data terbaru di tahun berjalan
                    string noSurat = GenerateNoSurat(conn);

                    string query = "INSERT INTO surat (no_surat, nik, nama_warga, jenis_surat, tanggal_pengajuan, status) " +
                                   "VALUES (@no_surat, @nik, @nama_warga, @jenis_surat, @tanggal_pengajuan, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no_surat", noSurat);
                        cmd.Parameters.AddWithValue("@nik", txtNIK.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama_warga", txtNamaWarga.Text.Trim());
                        cmd.Parameters.AddWithValue("@jenis_surat", cmbJenisSurat.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@tanggal_pengajuan", dtpTanggalPengajuan.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@status", "Pending");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pengajuan surat berhasil disimpan dengan nomor " + noSurat + "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form untuk pengajuan berikutnya
                        txtNIK.Clear();
                        txtNamaWarga.Clear();
                        dtpTanggalPengajuan.Value = DateTime.Now;
                        if (cmbJenisSurat.Items.Count > 0)
                            cmbJenisSurat.SelectedIndex = 0;

                        txtNoSurat.Text = GenerateNoSurat(conn);

                        // Refresh tabel data surat setelah simpan berhasil
                        TampilkanDataSurat();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pengajuan surat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mengisi field otomatis saat baris di dgvTransaksiSurat diklik, lalu masuk mode edit
        private void dgvTransaksiSurat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksiSurat.Rows[e.RowIndex];
                noSuratSelected = row.Cells["No. Surat"].Value.ToString();

                txtNoSurat.Text = noSuratSelected;
                txtNIK.Text = row.Cells["NIK"].Value.ToString();
                txtNamaWarga.Text = row.Cells["Nama Warga"].Value.ToString();
                cmbJenisSurat.SelectedItem = row.Cells["Jenis Surat"].Value.ToString();

                object tglValue = row.Cells["Tanggal Pengajuan"].Value;
                DateTime tgl;
                if (tglValue != null && tglValue != DBNull.Value && DateTime.TryParse(tglValue.ToString(), out tgl))
                {
                    dtpTanggalPengajuan.Value = tgl;
                }
            }
        }

        // Mengembalikan form ke mode pengajuan baru
        private void ClearFormTransaksi()
        {
            txtNIK.Clear();
            txtNamaWarga.Clear();
            dtpTanggalPengajuan.Value = DateTime.Now;
            if (cmbJenisSurat.Items.Count > 0)
                cmbJenisSurat.SelectedIndex = 0;
            noSuratSelected = "";

            TampilkanPreviewNoSurat();
        }

        // Tombol Ubah (UPDATE data surat berdasarkan no_surat yang dipilih)
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noSuratSelected))
            {
                MessageBox.Show("Pilih data pengajuan surat dari tabel yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput())
                return;

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "UPDATE surat SET nik=@nik, nama_warga=@nama_warga, jenis_surat=@jenis_surat, tanggal_pengajuan=@tanggal_pengajuan WHERE no_surat=@no_surat";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", txtNIK.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama_warga", txtNamaWarga.Text.Trim());
                        cmd.Parameters.AddWithValue("@jenis_surat", cmbJenisSurat.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@tanggal_pengajuan", dtpTanggalPengajuan.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@no_surat", noSuratSelected);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data pengajuan surat berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TampilkanDataSurat();
                        ClearFormTransaksi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Hapus (DELETE data surat berdasarkan no_surat yang dipilih)
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noSuratSelected))
            {
                MessageBox.Show("Pilih data pengajuan surat dari tabel yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data pengajuan surat ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = Koneksi.GetKoneksi())
                    {
                        conn.Open();

                        string query = "DELETE FROM surat WHERE no_surat=@no_surat";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@no_surat", noSuratSelected);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data pengajuan surat berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TampilkanDataSurat();
                            ClearFormTransaksi();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
