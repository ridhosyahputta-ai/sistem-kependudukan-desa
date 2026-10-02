using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormLaporanSurat : Form
    {
        private ReportDocument laporan;
        private DataSet dataLaporan;

        public FormLaporanSurat()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                Cursor = Cursors.WaitCursor;
                dataLaporan = AmbilDataLaporan();
                laporan = BuatLaporan(dataLaporan);
                crystalReportViewer.ReportSource = laporan;
            }
            catch (Exception ex)
            {
                LepaskanLaporan();
                MessageBox.Show(this, "Laporan tidak dapat dibuka. Pastikan database dan runtime Crystal Reports 32-bit tersedia.\n\n" + ex.Message,
                    "Laporan Pengajuan Surat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        internal static DataSet AmbilDataLaporan()
        {
            DataSet data = new DataSet("LaporanPengajuanSurat");
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();
                    // Nama pada template lama adalah surat.nama_warga; nilainya tetap
                    // berasal dari penduduk.nama tanpa mengubah desain file RPT.
                    string querySurat = "SELECT s.id_surat, s.no_surat, s.nik, p.nama AS nama_warga, " +
                        "s.jenis_surat, s.tanggal_pengajuan, s.status, s.catatan " +
                        "FROM surat s INNER JOIN penduduk p ON p.nik = s.nik " +
                        "ORDER BY s.tanggal_pengajuan DESC, s.id_surat DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(querySurat, conn))
                    {
                        adapter.Fill(data, "surat");
                    }

                    string queryPenduduk = "SELECT p.nik, p.nama, p.alamat, p.jenis_kelamin, p.agama, p.tanggal_lahir " +
                        "FROM penduduk p WHERE EXISTS (SELECT 1 FROM surat s WHERE s.nik = p.nik)";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryPenduduk, conn))
                    {
                        adapter.Fill(data, "penduduk");
                    }
                }

                data.Relations.Add("PendudukSurat", data.Tables["penduduk"].Columns["nik"],
                    data.Tables["surat"].Columns["nik"], false);
                return data;
            }
            catch
            {
                data.Dispose();
                throw;
            }
        }

        internal static ReportDocument BuatLaporan(DataSet data)
        {
            string reportPath = Path.Combine(Application.StartupPath, "Laporan Daftar Pengajuan Surat - Desa.rpt");
            if (!File.Exists(reportPath))
                throw new FileNotFoundException("File laporan tidak ditemukan di folder aplikasi.", reportPath);

            ReportDocument report = new ReportDocument();
            try
            {
                report.Load(reportPath, OpenReportMethod.OpenReportByTempCopy);
                // Dua tabel nyata dipasok lewat koneksi aplikasi; tidak memerlukan
                // DSN atau password tersimpan di dalam report.
                report.SetDataSource(data);
                return report;
            }
            catch
            {
                report.Close();
                report.Dispose();
                throw;
            }
        }

        private void LepaskanLaporan()
        {
            crystalReportViewer.ReportSource = null;
            if (laporan != null)
            {
                laporan.Close();
                laporan.Dispose();
                laporan = null;
            }
            if (dataLaporan != null)
            {
                dataLaporan.Dispose();
                dataLaporan = null;
            }
        }
    }
}
