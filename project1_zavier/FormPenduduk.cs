using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Library MySQL

namespace project1_ridho
{
    public partial class FormPenduduk : Form
    {
        // Menyimpan NIK data yang sedang dipilih/diedit dari tabel
        private string nikSelected = "";

        public FormPenduduk()
        {
            InitializeComponent();
        }

        // Menampilkan seluruh data penduduk ke dgvPenduduk
        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    string query = "SELECT nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat', jenis_kelamin AS 'Jenis Kelamin', agama AS 'Agama', tanggal_lahir AS 'Tanggal Lahir' FROM penduduk";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvPenduduk.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penduduk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPenduduk_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input
            if (string.IsNullOrWhiteSpace(txtNIK.Text) || string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("NIK dan Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Buka Koneksi ke MySQL
                using (MySqlConnection conn = project1_ridho.Koneksi.GetKoneksi())
                {
                    conn.Open();

                    // 3. Query Query Simpan
                    string query = "INSERT INTO penduduk (nik, nama, alamat, jenis_kelamin, agama, tanggal_lahir) " +
                                   "VALUES (@nik, @nama, @alamat, @jk, @agama, @tgl)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nik", txtNIK.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                        cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@agama", cmbAgama.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));

                        // 4. Eksekusi
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Penduduk Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset Inputan
                        txtNIK.Clear();
                        txtNama.Clear();
                        txtAlamat.Clear();

                        // Refresh tabel data penduduk setelah simpan berhasil
                        TampilData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        // Mengisi field otomatis saat baris di dgvPenduduk diklik, lalu masuk mode edit (NIK dikunci)
        private void dgvPenduduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPenduduk.Rows[e.RowIndex];
                nikSelected = row.Cells["NIK"].Value.ToString();

                txtNIK.Text = nikSelected;
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                txtAlamat.Text = row.Cells["Alamat"].Value.ToString();
                cmbJenisKelamin.SelectedItem = row.Cells["Jenis Kelamin"].Value.ToString();
                cmbAgama.SelectedItem = row.Cells["Agama"].Value.ToString();

                object tglValue = row.Cells["Tanggal Lahir"].Value;
                DateTime tgl;
                if (tglValue != null && tglValue != DBNull.Value && DateTime.TryParse(tglValue.ToString(), out tgl))
                {
                    dtpTanggalLahir.Value = tgl;
                }

                // NIK dikunci selama mode edit supaya tidak berubah jadi NIK lain saat update
                txtNIK.ReadOnly = true;
            }
        }

        // Mengembalikan form ke mode tambah data baru (NIK terbuka lagi)
        private void ClearFormPenduduk()
        {
            txtNIK.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            cmbJenisKelamin.SelectedIndex = -1;
            cmbAgama.SelectedIndex = -1;
            txtNIK.ReadOnly = false;
            nikSelected = "";
        }

        // Tombol Ubah (UPDATE data penduduk berdasarkan NIK yang dipilih)
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nikSelected))
            {
                MessageBox.Show("Pilih data penduduk dari tabel yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNIK.Text) || string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("NIK dan Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "UPDATE penduduk SET nama=@nama, alamat=@alamat, jenis_kelamin=@jk, agama=@agama, tanggal_lahir=@tgl WHERE nik=@nik";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                        cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@agama", cmbAgama.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@nik", nikSelected);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data penduduk berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TampilData();
                        ClearFormPenduduk();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Hapus (DELETE data penduduk berdasarkan NIK yang dipilih)
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nikSelected))
            {
                MessageBox.Show("Pilih data penduduk dari tabel yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data penduduk ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = Koneksi.GetKoneksi())
                    {
                        conn.Open();

                        string query = "DELETE FROM penduduk WHERE nik=@nik";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nik", nikSelected);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data penduduk berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TampilData();
                            ClearFormPenduduk();
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
            // Menutup form penduduk dan kembali ke menu utama
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string defaultFileName = "DataPenduduk_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            ExportHelper.ExportDataGridViewToCsv(dgvPenduduk, defaultFileName);
        }
    }
}