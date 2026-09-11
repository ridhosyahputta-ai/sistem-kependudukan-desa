using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace project1_ridho
{
    public static class ExportHelper
    {
        // Fungsi reusable untuk export seluruh isi DataGridView ke file CSV
        public static void ExportDataGridViewToCsv(DataGridView dgv, string defaultFileName)
        {
            if (dgv.Columns.Count == 0 || dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diexport!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = defaultFileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            // Tulis header kolom
                            string[] headers = new string[dgv.Columns.Count];
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                headers[i] = CsvEscape(dgv.Columns[i].HeaderText);
                            }
                            writer.WriteLine(string.Join(",", headers));

                            // Tulis isi baris
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string[] values = new string[dgv.Columns.Count];
                                for (int i = 0; i < dgv.Columns.Count; i++)
                                {
                                    object cellValue = row.Cells[i].Value;
                                    string cellText;
                                    if (cellValue is DateTime dateValue)
                                    {
                                        cellText = dateValue.ToString("dd/MM/yyyy");
                                    }
                                    else
                                    {
                                        cellText = cellValue?.ToString() ?? string.Empty;
                                    }
                                    values[i] = CsvEscape(cellText);
                                }
                                writer.WriteLine(string.Join(",", values));
                            }
                        }

                        MessageBox.Show("Data berhasil diexport ke:\n" + sfd.FileName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal mengexport data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Bungkus nilai dengan tanda kutip ganda jika mengandung koma, kutip, atau newline
        private static string CsvEscape(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }
    }
}
