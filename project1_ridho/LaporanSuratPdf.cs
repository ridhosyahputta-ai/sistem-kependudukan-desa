using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace project1_ridho
{
    internal static class LaporanSuratPdf
    {
        internal static string EksporPdf(DataSet data)
        {
            string folder = Path.Combine(Path.GetTempPath(), "SistemKependudukanDesa", "LaporanSurat");
            Directory.CreateDirectory(folder);
            string path = Path.Combine(folder, "PengajuanSurat_" + Guid.NewGuid().ToString("N") + ".pdf");
            bool fileDibuat = false;
            try
            {
                using (ReportDocument report = FormLaporanSurat.BuatLaporan(data))
                {
                    try
                    {
                        using (Stream pdf = report.ExportToStream(ExportFormatType.PortableDocFormat))
                        using (FileStream file = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                        {
                            fileDibuat = true;
                            pdf.CopyTo(file);
                        }
                    }
                    finally
                    {
                        report.Close();
                    }
                }
                return path;
            }
            catch
            {
                // Hanya hapus file parsial yang dibuat oleh ekspor ini.
                if (fileDibuat)
                {
                    try { File.Delete(path); }
                    catch (IOException) { }
                    catch (UnauthorizedAccessException) { }
                }
                throw;
            }
        }

        internal static ProcessStartInfo BuatInfoBrowser(string pdfPath)
        {
            string fullPath = Path.GetFullPath(pdfPath);
            if (!File.Exists(fullPath))
                throw new FileNotFoundException("File PDF laporan tidak ditemukan.", fullPath);

            // Cari executable handler HTTPS, bukan asosiasi .pdf (misalnya Acrobat).
            const uint assocIsProtocol = 0x00001000;
            const uint assocExecutable = 2;
            uint length = 0;
            AssocQueryString(assocIsProtocol, assocExecutable, "https", "open", null, ref length);
            if (length == 0 || length > 32768)
                throw new InvalidOperationException("Browser default Windows tidak ditemukan. Atur browser default melalui Settings Windows.");

            StringBuilder executable = new StringBuilder((int)length);
            int result = AssocQueryString(assocIsProtocol, assocExecutable, "https", "open", executable, ref length);
            string browserPath = Environment.ExpandEnvironmentVariables(executable.ToString()).Trim('"');
            // Windows dapat mengembalikan pemilih aplikasi jika default belum diatur.
            // Jangan memperlakukannya sebagai browser atau memakai asosiasi PDF.
            if (result != 0 || !File.Exists(browserPath) ||
                string.Equals(Path.GetFileName(browserPath), "OpenWith.exe", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Browser default Windows belum tersedia. Atur browser untuk tautan HTTPS melalui Settings Windows, lalu coba lagi.");

            return new ProcessStartInfo
            {
                FileName = browserPath,
                Arguments = "\"" + new Uri(fullPath).AbsoluteUri + "\"",
                UseShellExecute = false
            };
        }

        internal static void BukaPdf(string pdfPath)
        {
            using (Process process = Process.Start(BuatInfoBrowser(pdfPath)))
            {
                // Browser dapat meneruskan file ke jendela yang sudah terbuka.
            }
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint = "AssocQueryStringW")]
        private static extern int AssocQueryString(uint flags, uint str, string association,
            string extra, StringBuilder output, ref uint length);
    }
}
