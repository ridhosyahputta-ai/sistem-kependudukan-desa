using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class Form1 : Form
    {
        // Variable Static untuk menyimpan data user yang berhasil login
        // Variabel ini akan dibaca oleh FormMain untuk membatasi hak akses (Admin/Petugas/Lurah)
        public static string UserLoggedIn = "";
        public static string RoleLoggedIn = "";

        public Form1()
        {
            InitializeComponent();

            // Menghubungkan event click ke btnLogin_Click
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validasi jika inputan masih kosong
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            MySqlConnection conn = kon.GetConn();

            try
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Simpan nama lengkap dan role (level) user ke variabel static
                    UserLoggedIn = dr["nama_lengkap"].ToString();
                    RoleLoggedIn = dr["level"].ToString();

                    MessageBox.Show("Login Berhasil! Selamat Datang " + UserLoggedIn, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pindah ke FormMain (Dashboard Utama)
                    this.Hide();
                    FormMain main = new FormMain();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan Koneksi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}