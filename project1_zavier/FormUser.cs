using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormUser : Form
    {
        string idSelected = "";

        public FormUser()
        {
            InitializeComponent();

            // Pendaftaran event secara langsung via kode
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
            this.btnUbah.Click += new EventHandler(this.btnUbah_Click);
            this.btnHapus.Click += new EventHandler(this.btnHapus_Click);
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnKeluar.Click += new EventHandler(this.btnKeluar_Click); // <-- Pendaftaran tombol Keluar
            this.dgvUser.CellClick += new DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.Load += new EventHandler(this.FormUser_Load);
        }

        // 1. FUNGSI MENAMPILKAN DATA USER KE TABEL
        private void TampilData()
        {
            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "SELECT id AS 'ID', nama_lengkap AS 'Nama Lengkap', username AS 'Username', password AS 'Password', level AS 'Role' FROM users";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvUser.DataSource = dt;
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

        // 2. FUNGSI MENGAMBIL LIST ROLE DARI TABEL ROLES KE COMBOBOX
        private void LoadRoleComboBox()
        {
            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "SELECT nama_role FROM roles";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                cmbRole.Items.Clear();
                while (dr.Read())
                {
                    cmbRole.Items.Add(dr["nama_role"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data role: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // 3. FUNGSI MEMBERSIHKAN INPUT FORM
        private void ClearForm()
        {
            txtNama.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            idSelected = "";
            txtNama.Focus();
        }

        // 4. EVENT SAAT FORM DIBUKA
        private void FormUser_Load(object sender, EventArgs e)
        {
            TampilData();
            LoadRoleComboBox();
        }

        // 5. TOMBOL SIMPAN (CREATE + VALIDASI)
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi Input Kosong (Poin 3 Tugas)
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Semua kolom data (Nama, Username, Password, Role) wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "INSERT INTO users (nama_lengkap, username, password, level) VALUES ('" +
                                txtNama.Text.Trim() + "', '" +
                                txtUsername.Text.Trim() + "', '" +
                                txtPassword.Text.Trim() + "', '" +
                                cmbRole.SelectedItem.ToString() + "')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data user berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 6. EVENT KLIK BARIS TABEL (DATAGRIDVIEW)
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                idSelected = row.Cells["ID"].Value.ToString();
                txtNama.Text = row.Cells["Nama Lengkap"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }

        // 7. TOMBOL UBAH (UPDATE)
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("Pilih data user dari tabel yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Semua kolom data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();
            try
            {
                conn.Open();
                string query = "UPDATE users SET nama_lengkap='" + txtNama.Text.Trim() +
                               "', username='" + txtUsername.Text.Trim() +
                               "', password='" + txtPassword.Text.Trim() +
                               "', level='" + cmbRole.SelectedItem.ToString() +
                               "' WHERE id='" + idSelected + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data user berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 8. TOMBOL HAPUS (DELETE)
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("Pilih data user dari tabel yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus user ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Koneksi kon = new Koneksi();
                MySqlConnection conn = kon.GetConn();
                try
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE id='" + idSelected + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data user berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 9. TOMBOL CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // 10. TOMBOL KELUAR
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup FormUser dan kembali ke FormMain
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}