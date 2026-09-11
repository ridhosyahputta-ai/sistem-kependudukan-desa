using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormMain_Load);

            // Event Klik Tombol Utama
            this.btnDataRole.Click += (s, e) => new FormRole().ShowDialog();
            this.btnDataUser.Click += (s, e) => new FormUser().ShowDialog();
            this.btnDataPenduduk.Click += new EventHandler(this.btnDataPenduduk_Click);
            this.btnTransaksiSurat.Click += (s, e) => new FormTransaksiSurat().ShowDialog();
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Tambahkan baris ini untuk mengubah teks ucapan di header
            lblSelamatDatang.Text = "Selamat Datang di Menu Utama Navigasi Data, " + Form1.UserLoggedIn + "!";

            string role = Form1.RoleLoggedIn.Trim().ToLower();

            // Reset awal: matikan semua tombol
            btnDataRole.Enabled = false;
            btnDataUser.Enabled = false;
            btnDataPenduduk.Enabled = false;

            if (role.Contains("admin"))
            {
                btnDataRole.Enabled = true;
                btnDataUser.Enabled = true;
                btnDataPenduduk.Enabled = true;
            }
            else if (role.Contains("petugas"))
            {
                btnDataRole.Enabled = false;
                btnDataUser.Enabled = true;
                btnDataPenduduk.Enabled = true;
            }
            else if (role.Contains("lurah"))
            {
                btnDataRole.Enabled = false;
                btnDataUser.Enabled = false;
                btnDataPenduduk.Enabled = true;
            }

            LoadDashboard();
        }

        // Mengambil ringkasan jumlah data penduduk & pengajuan surat untuk ditampilkan di dashboard
        private void LoadDashboard()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    lblTotalPenduduk.Text = HitungJumlah(conn, "SELECT COUNT(*) FROM penduduk");
                    lblTotalPending.Text = HitungJumlah(conn, "SELECT COUNT(*) FROM surat WHERE status = 'Pending'");
                    lblTotalDisetujui.Text = HitungJumlah(conn, "SELECT COUNT(*) FROM surat WHERE status = 'Disetujui'");
                    lblTotalDitolak.Text = HitungJumlah(conn, "SELECT COUNT(*) FROM surat WHERE status = 'Ditolak'");

                    // Aktivitas terbaru: 5 pengajuan surat paling baru
                    string queryAktivitas = "SELECT no_surat, nama_warga, jenis_surat, status FROM surat ORDER BY id_surat DESC LIMIT 5";
                    MySqlDataAdapter da = new MySqlDataAdapter(queryAktivitas, conn);
                    DataTable dtAktivitas = new DataTable();
                    da.Fill(dtAktivitas);
                    dgvAktivitasTerbaru.DataSource = dtAktivitas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HitungJumlah(MySqlConnection conn, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            }
        }

        private void btnDataPenduduk_Click(object sender, EventArgs e)
        {
            string role = Form1.RoleLoggedIn.Trim().ToLower();

            if (role.Contains("lurah"))
            {
                // Lurah -> Buka Approval Surat
                FormApproval approval = new FormApproval();
                approval.ShowDialog();
            }
            else
            {
                // Admin / Petugas -> Buka FormPenduduk
                FormPenduduk penduduk = new FormPenduduk();
                penduduk.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnDataRole_Click(object sender, EventArgs e)
        {

        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksiSurat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDataPenduduk_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}