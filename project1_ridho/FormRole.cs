using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormRole : Form
    {
        // Variabel penampung ID saat memilih data dari tabel
        string idSelected = "";

        public FormRole()
        {
            InitializeComponent();

            // Pendaftaran event tombol langsung lewat kode
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
            this.btnUbah.Click += new EventHandler(this.btnUbah_Click);
            this.btnHapus.Click += new EventHandler(this.btnHapus_Click);
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnKeluar.Click += new EventHandler(this.btnKeluar_Click); // <-- Pendaftaran tombol Keluar
            this.dgvRole.CellClick += new DataGridViewCellEventHandler(this.dgvRole_CellClick);
            this.Load += new EventHandler(this.FormRole_Load);
        }

        // 1. FUNGSI UNTUK MENAMPILKAN DATA DARI DATABASE KE DATAGRIDVIEW
        private void TampilData()
        {
            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "SELECT id AS 'ID', nama_role AS 'Nama Role' FROM roles";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvRole.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // 2. FUNGSI MEMBERSIHKAN INPUTAN
        private void ClearForm()
        {
            txtNamaRole.Text = "";
            idSelected = "";
            txtNamaRole.Focus();
        }

        // 3. EVENT SAAT FORM PERTAMA KALI DIBUKA
        private void FormRole_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        // 4. TOMBOL SIMPAN (CREATE + VALIDASI)
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi inputan kosong
            if (string.IsNullOrWhiteSpace(txtNamaRole.Text))
            {
                MessageBox.Show("Nama Role tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaRole.Focus();
                return;
            }

            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "INSERT INTO roles (nama_role) VALUES (@nama_role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_role", txtNamaRole.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data role berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Simpan: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // 5. EVENT KLIK TABEL (DATAGRIDVIEW)
        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRole.Rows[e.RowIndex];
                idSelected = row.Cells["ID"].Value.ToString();
                txtNamaRole.Text = row.Cells["Nama Role"].Value.ToString();
            }
        }

        // 6. TOMBOL UBAH (UPDATE)
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("Pilih data yang akan diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaRole.Text))
            {
                MessageBox.Show("Nama Role tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "UPDATE roles SET nama_role=@nama_role WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_role", txtNamaRole.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idSelected);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data role berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ubah: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // 7. TOMBOL HAPUS (DELETE)
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("Pilih data yang akan dihapus dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus role ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Koneksi kon = new Koneksi();
                MySqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "DELETE FROM roles WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idSelected);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data role berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Hapus: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // 8. TOMBOL CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // 9. TOMBOL KELUAR
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}