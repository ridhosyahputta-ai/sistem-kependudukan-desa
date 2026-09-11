using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public class Koneksi // Tambahkan 'public' di sini
    {
        private static string stringKoneksi = "server=localhost;user=root;database=db_kependudukan;password=;";

        public static MySqlConnection GetKoneksi() // Pakai 'public static' dan nama 'GetKoneksi'
        {
            MySqlConnection conn = new MySqlConnection(stringKoneksi);
            return conn;
        }

        // Fungsi lama kamu tetap disimpan agar kode lain tidak bentrok
        public MySqlConnection GetConn()
        {
            return GetKoneksi();
        }
    }
}