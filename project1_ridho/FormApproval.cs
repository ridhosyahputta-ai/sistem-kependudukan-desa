using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormApproval : Form
    {
        public FormApproval()
        {
            InitializeComponent();

            // Mendaftarkan Event
            this.Load += new EventHandler(FormApproval_Load);
            this.btnACC.Click += new EventHandler(btnACC_Click);
            this.btnTolak.Click += new EventHandler(btnTolak_Click);
            this.btnExportExcel.Click += new EventHandler(btnExportExcel_Click);
        }

        // Fungsi untuk mengambil data surat berstatus 'Pending' dari database
        private void LoadDataPending()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    string query = "SELECT id_surat, no_surat, nik, nama_warga, jenis_surat, tanggal_pengajuan, status FROM surat WHERE status = 'Pending'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvApproval.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data surat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormApproval_Load(object sender, EventArgs e)
        {
            LoadDataPending();
        }

        // Fungsi reusable untuk memperbarui status surat (Disetujui / Ditolak)
        private void UpdateStatusSurat(string statusBaru)
        {
            if (dgvApproval.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih baris surat yang ingin diproses!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil ID Surat dari baris yang dipilih di DataGridView
            string idSurat = dgvApproval.SelectedRows[0].Cells["id_surat"].Value.ToString();
            string catatan = txtCatatan.Text.Trim();

            if (statusBaru == "Ditolak" && string.IsNullOrWhiteSpace(catatan))
            {
                MessageBox.Show("Alasan penolakan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    string query = "UPDATE surat SET status = @status, catatan = @catatan WHERE id_surat = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", statusBaru);
                    cmd.Parameters.AddWithValue("@catatan", catatan);
                    cmd.Parameters.AddWithValue("@id", idSurat);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Surat berhasil di-" + statusBaru + "!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCatatan.Clear();
                    LoadDataPending(); // Refresh tabel setelah status berubah
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui status surat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnACC_Click(object sender, EventArgs e)
        {
            UpdateStatusSurat("Disetujui");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            UpdateStatusSurat("Ditolak");
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string defaultFileName = "DaftarSurat_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            ExportHelper.ExportDataGridViewToCsv(dgvApproval, defaultFileName);
        }
    }
}