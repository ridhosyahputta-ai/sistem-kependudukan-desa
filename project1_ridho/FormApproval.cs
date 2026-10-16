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

            // Pembaruan tampilan saja; tidak mengubah pilihan atau status surat.
            this.dgvApproval.SelectionChanged += PerbaruiTampilanSurat;
            this.dgvApproval.DataBindingComplete += PerbaruiTampilanSurat;
            this.dgvApproval.RowsAdded += PerbaruiTampilanSurat;
            this.dgvApproval.RowsRemoved += PerbaruiTampilanSurat;
        }

        private void PerbaruiTampilanSurat(object sender, EventArgs e)
        {
            lblKosong.Visible = dgvApproval.Rows.Count == 0;
            if (lblKosong.Visible)
                lblKosong.BringToFront();

            if (dgvApproval.SelectedRows.Count == 0 || dgvApproval.SelectedRows[0].IsNewRow)
            {
                lblSuratTerpilih.Text = "Pilih satu pengajuan pada tabel untuk melihat ringkasan surat.";
                return;
            }

            DataGridViewRow row = dgvApproval.SelectedRows[0];
            lblSuratTerpilih.Text = "No. Surat: " + Convert.ToString(row.Cells["no_surat"].Value) +
                "\r\nNama: " + Convert.ToString(row.Cells["nama_warga"].Value) +
                "\r\nJenis: " + Convert.ToString(row.Cells["jenis_surat"].Value);
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
                    dgvApproval.ClearSelection();
                    dgvApproval.CurrentCell = null;
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
            DataGridViewRow row = dgvApproval.SelectedRows[0];
            if (row.IsNewRow || !dgvApproval.Columns.Contains("id_surat") ||
                string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["id_surat"].Value)))
            {
                dgvApproval.ClearSelection();
                dgvApproval.CurrentCell = null;
                MessageBox.Show("Silakan pilih baris surat yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idSurat = Convert.ToString(row.Cells["id_surat"].Value);
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
