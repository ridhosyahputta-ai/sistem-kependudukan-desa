# Sistem Kependudukan Desa

Aplikasi administrasi desa berbasis C# Windows Forms untuk mengelola penduduk,
pengguna, role, pengajuan surat, persetujuan, dan laporan PDF. Project tugas
Pemrograman Desktop oleh Ridho Syach Putra, SMK TI Pembangunan Cimahi, RPL.

## UI dan fitur terbaru

| Form | Kondisi |
|---|---|
| Login / Form1 | Dua panel, logo, navy, Segoe UI, dan tombol masuk |
| Dashboard / FormMain | Sidebar, empat kartu ringkasan, dan aktivitas terbaru |
| FormRole | Redesign panel input, tombol tindakan, dan tabel dua kolom |
| FormPenduduk | Redesign input dua kolom, alamat multiline, dan tabel proporsional |
| FormTransaksiSurat | Redesign input dua kolom, tabel, dan tombol laporan PDF |
| FormApproval | Redesign daftar Pending, ringkasan pilihan, catatan multiline, dan keterangan daftar kosong |
| FormUser | Pengelolaan akun; belum termasuk redesign empat form di atas |

Empat form yang diperbarui menggunakan navy, latar terang, Segoe UI, tombol flat,
dan layout yang mengikuti ukuran jendela. Ukuran awal dirancang untuk laptop
1366 × 768 pada skala normal; DPI lain tetap perlu diuji. Login/Dashboard masih
memakai ukuran tetap.

Khusus Lurah, sidebar **Persetujuan Surat** tetap membuka FormApproval.
Admin dan Petugas tetap melihat **Data Penduduk (NIK)** yang membuka FormPenduduk.
Perubahan label tidak mengubah aturan akses.

Fitur yang tersedia:

- CRUD penduduk, pengguna, dan role.
- Delapan jenis surat: domisili, usaha, tidak mampu, pengantar KTP, kelahiran,
  kematian, pengantar nikah, dan pindah.
- Nomor surat otomatis dan validasi NIK pengajuan berupa 16 digit angka.
- Persetujuan/penolakan surat Pending; alasan penolakan wajib diisi.
- Dashboard jumlah penduduk dan pengajuan per status serta aktivitas terbaru.
- Ekspor daftar ke **CSV yang dapat dibuka di Excel**, bukan workbook XLSX.
- **Satu klik Laporan Pengajuan Surat → ekspor PDF → buka browser default Windows**.

Pencarian/filter daftar dan pagination belum tersedia pada form yang diperbarui.

## Teknologi dan dependensi

| Komponen | Kebutuhan |
|---|---|
| UI | C# Windows Forms |
| Framework | .NET Framework 4.7.2 |
| IDE | Visual Studio 2019; workload .NET desktop development |
| Database | MySQL dan MySQL Connector/NET |
| NuGet | Sesuai packages.config, termasuk MySql.Data 26.7.0 |
| Laporan | SAP Crystal Reports for Visual Studio SP32 dan runtime 32-bit yang sesuai |
| Arsitektur | Any CPU dengan Prefer 32-bit aktif |
| Browser | Browser default HTTPS Windows dengan dukungan PDF |

Instalasi Crystal Reports lokal yang diuji memakai versi file **13.0.32.4286**
dan assembly CrystalDecisions **13.0.4000.0**. DLL managed saja tidak menggantikan
instalasi runtime native.

## Crystal Reports dan PDF

Template: `project1_ridho/Laporan Daftar Pengajuan Surat - Desa.rpt`.

Tombol laporan memiliki satu handler Click. Data diambil melalui
`FormLaporanSurat.AmbilDataLaporan()`, lalu template dimuat melalui
`BuatLaporan()`. Helper `LaporanSuratPdf` mengekspor PDF dan menjalankan browser
yang terdaftar untuk HTTPS, bukan aplikasi pembaca PDF berdasarkan asosiasi .pdf.

PDF disimpan dengan nama unik:
`%TEMP%/SistemKependudukanDesa/LaporanSurat/PengajuanSurat_<GUID>.pdf`.

File parsial dibersihkan saat ekspor gagal. PDF sukses dipertahankan agar dapat
dibaca browser; pembersihan berkala belum diterapkan. Jika pembukaan browser
gagal, pesan menampilkan lokasi PDF dan tombol kembali aktif. Aplikasi tidak
mengubah pengaturan browser. Preferensi browser yang memaksa unduhan PDF tetap
mengikuti pengaturan pengguna.

Laporan memakai DataSet berisi tabel surat dan penduduk. INNER JOIN berdasarkan
NIK mengambil nama dari penduduk.nama; surat tanpa pasangan penduduk tidak masuk
laporan. Tidak perlu membuat DSN tambahan untuk alur ini. Template diperiksa
tanpa saved data maupun password koneksi.

FormLaporanSurat dan CrystalReportViewer tetap tersedia dalam source sebagai
cadangan; tombol utama tidak membuka viewer terlebih dahulu. Template otomatis
disalin ke output build. Lihat [panduan laporan](docs/crystal-reports.md).

## Cara menjalankan

1. Instal Visual Studio 2019, workload .NET desktop development, dan .NET Framework
   4.7.2 targeting pack.
2. Instal SAP Crystal Reports for Visual Studio dan runtime 32-bit yang sesuai.
3. Siapkan MySQL lokal dengan database `db_kependudukan` dan tabel roles, users,
   penduduk, serta surat sesuai query pada source.
4. **SQL bawaan belum lengkap untuk instalasi baru.** `db_kependudukan.sql` hanya
   berisi struktur roles/users dan seed tiga nama role, tanpa akun login, data
   penduduk, atau data surat. Skema penduduk/surat perlu disiapkan secara lokal
   sesuai lingkungan yang sudah berfungsi. Jangan mengimpor ulang SQL ke database
   yang sudah berisi data.
5. Periksa `project1_ridho/Koneksi.cs`. Versi ini memakai localhost dengan akun
   database pengembangan dan password kosong. Jangan commit kredensial nyata.
6. Buka `project1_ridho.sln`, lalu lakukan **Restore NuGet Packages**. Folder packages
   tidak disimpan di repository.
7. Pastikan reference CrystalDecisions terselesaikan. Jika lokasi instalasi berbeda,
   set properti MSBuild `CrystalReportsAssemblyPath` ke folder DLL managed Crystal
   Reports. HintPath default menunjuk instalasi SAP di Program Files (x86).
8. Pilih startup project project1_ridho, konfigurasi **Debug | Any CPU**, dan pastikan
   **Prefer 32-bit** aktif. Pilih **Build > Rebuild Solution**.
9. Tekan **F5** dan gunakan akun yang sudah disiapkan secara lokal. Kredensial akun
   tidak disertakan dalam repository.
10. Atur browser default HTTPS di Settings Windows, buka **Transaksi Surat**, lalu
    klik **Laporan Pengajuan Surat** sekali.

Tidak perlu menjalankan migrasi keamanan untuk versi ini. Finalisasi repository
tidak menjalankan import SQL, migrasi, atau perubahan data.

## Status keamanan sesuai source versi ini

Dokumentasi berikut mengikuti kode lokal, bukan klaim dari versi/direktori lain:

- Login memakai parameter SQL tetapi membandingkan password langsung dengan
  users.password.
- FormUser masih menyimpan password teks biasa dan memasukkan kolom Password ke
  DataGridView; password belum disembunyikan pada form tersebut.
- Tidak ada PasswordHasher, PBKDF2, bcrypt/Argon2, migrasi hash, hashing asynchronous,
  atau rangkaian pengujian keamanan Stage 1–2B dalam source versi ini.
- Pembatasan role berada pada tombol/navigasi FormMain. Petugas masih mendapat
  akses menu Manajemen User dan Lurah masih dapat membuka Transaksi Surat.
  Ini belum merupakan otorisasi terpusat pada setiap operasi CRUD.
- Belum ada pembatasan percobaan login atau perlindungan akun Admin terakhir.
- Finalisasi ini tidak mengubah login, penyimpanan password, atau hak akses.

Versi ini untuk tugas/pengembangan dan belum dinyatakan siap untuk data pribadi
produksi. SQL berparameter tidak menggantikan hashing password atau otorisasi.

## Status pengujian dan batasan

- Build Debug MSBuild Visual Studio 2019: **0 warning, 0 error**.
- FormRole, FormPenduduk, FormTransaksiSurat, dan FormApproval berhasil dimuat dengan
  **DesignSurface / FormDocumentDesigner**; identifier komponen diperiksa.
  Ini bukan otomatisasi tab Design VS2019.
- Layout diperiksa pada beberapa ukuran jendela dengan data sintetis, tanpa
  operasi database. Binding, pemilihan baris, multiline, serta ringkasan dan
  keadaan kosong FormApproval sudah diperiksa.
- Ekspor PDF untuk DataSet kosong dan satu baris sintetis berhasil. Tombol laporan
  memiliki satu handler aktif; pemuatan Designer tidak membuat PDF.
- Pengguna mengonfirmasi FormPenduduk telah diuji secara visual dan PDF berhasil
  terbuka di Google Chrome secara manual; ini bukan hasil tes otomatis.

Belum diverifikasi menyeluruh: instalasi dari clone baru, setup skema database
lengkap, CRUD/persetujuan terhadap database nyata, semua kombinasi role, DPI
125%/150%, panjang data yang beragam, browser selain Chrome, dan seluruh tab
Designer VS2019 secara interaktif. Build Release dan tes keamanan tidak diklaim
telah dilakukan pada finalisasi ini.

## Isi repository

Source, resource UI, template RPT, manifest dependensi, solution, dan dokumentasi
disimpan di Git. .gitignore mengecualikan .vs, bin, obj, packages, konfigurasi lokal
rahasia, pola backup database, serta ekspor sementara. Hasil PDF tidak perlu di Git.

## English overview

A C# WinForms village administration school project targeting .NET Framework
4.7.2 and Visual Studio 2019, using MySQL and Crystal Reports SP32 (32-bit).
Role, resident, submission, and approval screens share a navy/Segoe UI design.
The Village Head sees “Persetujuan Surat”. One report-button click exports a
temporary PDF and opens the default browser; the viewer remains in source.

Debug builds and synthetic designer/layout/PDF checks passed. Setup SQL is
incomplete for a fresh deployment. This version still uses plaintext password
storage and UI-based role restrictions. Earlier password-hashing, migration,
and security test claims do not apply to this source. See the precise limitations
and setup instructions above.

Development assistance: ChatGPT (OpenAI), OpenAI Codex, and Claude (Anthropic).
