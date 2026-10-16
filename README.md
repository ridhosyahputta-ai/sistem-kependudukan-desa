# Sistem Kependudukan Desa

**Aplikasi Administrasi Kependudukan Berbasis Desktop**

Aplikasi desktop untuk membantu pengelolaan data penduduk, administrasi pengguna, pengajuan surat, persetujuan surat, dan laporan kependudukan di lingkungan desa atau kelurahan.

Project ini dikembangkan sebagai bagian dari tugas mata pelajaran **Pemrograman Desktop**.

## Identitas Pengembang

- **Nama:** Ridho Syach Putra
- **Sekolah:** SMK TI Pembangunan Cimahi
- **Jurusan:** Rekayasa Perangkat Lunak (RPL)
- **Bahasa Pemrograman:** C#
- **Platform:** Windows Desktop

## Teknologi

| Teknologi | Kegunaan |
|---|---|
| C# WinForms | Pengembangan antarmuka desktop |
| .NET Framework 4.7.2 | Framework aplikasi |
| Visual Studio 2019 | IDE pengembangan |
| MySQL | Sistem manajemen database |
| MySQL Connector/NET | Koneksi C# ke MySQL |
| SAP Crystal Reports | Pembuatan dan pencetakan laporan |
| Git & GitHub | Version control |

## Fitur Aplikasi

### Autentikasi dan Hak Akses

Aplikasi memiliki tiga role utama:

- **Admin:** Pengelolaan akun, master role, data penduduk, dan pengajuan surat.
- **Petugas:** Pengelolaan data penduduk dan pengajuan surat.
- **Lurah:** Persetujuan atau penolakan pengajuan surat.

Pemeriksaan hak akses Admin untuk pengelolaan akun dan role telah diperkuat pada tahap pengembangan keamanan terbaru.

### Pengelolaan Data Penduduk

- Menambahkan data penduduk.
- Menampilkan daftar penduduk.
- Mengubah data penduduk.
- Menghapus data penduduk.
- Mencari dan memilih data.
- Mengekspor data dalam format CSV.

### Pengajuan Surat

Mendukung delapan jenis surat:

1. Surat Keterangan Domisili
2. Surat Keterangan Usaha
3. Surat Keterangan Tidak Mampu
4. Surat Pengantar KTP
5. Surat Keterangan Kelahiran
6. Surat Keterangan Kematian
7. Surat Pengantar Nikah
8. Surat Keterangan Pindah

Tersedia fitur pembuatan nomor surat otomatis, pengelolaan pengajuan, dan pemantauan status.

### Approval Surat

Lurah dapat meninjau pengajuan surat dengan status Pending, menyetujui atau menolak pengajuan, dan memberikan catatan atau alasan penolakan.

### Dashboard

Dashboard menampilkan informasi ringkasan, termasuk jumlah penduduk, status pengajuan surat, dan pengajuan terbaru.

### Crystal Reports

Aplikasi telah terintegrasi dengan CrystalReportViewer untuk menampilkan, mencetak, dan mengekspor laporan pengajuan surat.

Laporan menggunakan dua tabel MySQL:

- `penduduk`
- `surat`

Keduanya dihubungkan menggunakan kolom `nik`, sedangkan nama warga pada laporan diperoleh dari `penduduk.nama`.

Template laporan:

`project1_ridho/Laporan Daftar Pengajuan Surat - Desa.rpt`

Integrasi menggunakan SAP Crystal Reports for Visual Studio SP32 dengan runtime 32-bit yang sesuai.

## Pengembangan Keamanan

Pengembangan keamanan dilakukan secara bertahap.

**Tahap 1 — Fondasi Keamanan**

- Implementasi PasswordHasher berbasis PBKDF2-HMAC-SHA256.
- Salt acak dan format hash berversi.
- Pemeriksaan role yang lebih ketat.
- Pembatasan pengelolaan akun untuk Admin.
- Penyembunyian password dari DataGridView.

**Tahap 2 — Integrasi Autentikasi**

- Dukungan autentikasi password hash.
- Jalur kompatibilitas untuk akun lama.
- Migrasi password bertahap setelah login berhasil.
- Proses hashing di worker thread untuk menjaga responsivitas UI.
- Penanganan migrasi bersamaan.

**Tahap 2B — Pengujian MySQL**

Pengujian dilakukan menggunakan database terpisah bernama `db_kependudukan_security_test_stage2`, dengan akun sintetis tanpa menggunakan data penduduk asli.

| Pengujian | Hasil |
|---|---|
| Pengujian offline | 31 lulus, 0 gagal |
| Pengujian MySQL | 8 lulus, 0 gagal |
| Build Debug | Berhasil |
| Build Release | Berhasil |

**Status keamanan:** Implementasi dan pengujian database terpisah telah selesai. Migrasi autentikasi pada database utama belum diaktifkan. Pembatasan percobaan login, perlindungan Admin terakhir, dan penguatan otorisasi masih menjadi pekerjaan lanjutan.

## Persyaratan Sistem

- Windows
- Visual Studio 2019
- .NET Framework 4.7.2
- MySQL Server
- MySQL Connector/NET
- SAP Crystal Reports for Visual Studio SP32 dan runtime 32-bit yang kompatibel

## Cara Menjalankan

1. Siapkan MySQL Server dan database `db_kependudukan`.
2. Pastikan tabel yang diperlukan tersedia: `roles`, `users`, `penduduk`, dan `surat`.
3. Buka `project1_ridho.sln` menggunakan Visual Studio 2019.
4. Periksa konfigurasi koneksi pada `Koneksi.cs`.
5. Pastikan dependensi MySQL dan Crystal Reports terpasang.
6. Build project dan jalankan aplikasi.

**Catatan database:** File `db_kependudukan.sql` yang tersedia sebelumnya belum mencakup seluruh tabel aplikasi. Oleh karena itu, impor file tersebut saja belum cukup untuk menjalankan semua fitur.

Skrip migrasi keamanan berada pada folder `database/migrations/` dan tidak boleh dijalankan langsung pada database utama tanpa persiapan, cadangan data, dan pengujian.

## Struktur Project

```text
project1_ridho/
├── Form1.cs
├── FormMain.cs
├── FormPenduduk.cs
├── FormTransaksiSurat.cs
├── FormApproval.cs
├── FormRole.cs
├── FormUser.cs
├── FormLaporanSurat.cs
├── Koneksi.cs
├── PasswordHasher.cs
├── AuthenticationService.cs
├── AuthorizationService.cs
├── UserSession.cs
└── project1_ridho.csproj

database/
├── migrations/
└── testing/

tests/
└── Security.Tests/

docs/
├── security-stage1.md
├── security-stage2.md
└── security-stage2b.md
```

## Status Project

Project telah memiliki fitur utama administrasi kependudukan, pengajuan surat, approval, dashboard, dan integrasi laporan.

Pengembangan keamanan Tahap 1–2B telah diuji, tetapi masih terdapat pekerjaan lanjutan sebelum seluruh mekanisme keamanan digunakan pada database utama.

Pengujian langsung seluruh fitur CRUD melalui UI dan pencetakan Crystal Reports masih diperlukan.

## Kredit

**Pengembang:** Ridho Syach Putra

**Bantuan pengembangan:** ChatGPT (OpenAI), OpenAI Codex, dan Claude (Anthropic).

AI digunakan sebagai asisten untuk analisis kode, debugging, pengembangan fitur, dokumentasi, dan pengujian. Pengembangan dan pengelolaan repository berada di bawah tanggung jawab pemilik project.

---

# Village Population Administration System

A Windows desktop application for managing village population records, user accounts, certificate requests, approvals, and administrative reports.

Developed as a **Desktop Programming school project**.

## Developer

- **Name:** Ridho Syach Putra
- **School:** SMK TI Pembangunan Cimahi
- **Major:** Software Engineering (RPL)

## Technology Stack

C# WinForms, .NET Framework 4.7.2, Visual Studio 2019, MySQL, MySQL Connector/NET, and SAP Crystal Reports.

## Main Features

- Role-based login for Admin, Staff, and Village Head.
- Resident data management (CRUD).
- Eight types of administrative letter requests.
- Automatic letter numbering.
- Letter approval and rejection with notes.
- Dashboard statistics and recent submissions.
- CSV export.
- Crystal Reports integration using the `penduduk` and `surat` tables.

## Security Development

Security improvements include PBKDF2-HMAC-SHA256 password hashing, versioned hash formats, stricter role authorization, legacy account migration support, and asynchronous hashing.

Security Stages 1–2B have passed 31 offline tests and 8 MySQL integration tests using a separate synthetic test database.

**Important:** Production password migration has not been activated. Additional authorization hardening and end-to-end UI testing are still required.

## Setup

1. Install Visual Studio 2019 and the required .NET Framework.
2. Prepare a MySQL database named `db_kependudukan`.
3. Ensure the `roles`, `users`, `penduduk`, and `surat` tables exist.
4. Configure the database connection in `Koneksi.cs`.
5. Install the required Crystal Reports components.
6. Open the solution, build, and run the application.

The bundled SQL file may not contain the complete application schema. Do not execute security migration scripts against the main database without appropriate backups and testing.

## Development Credits

Developed by **Ridho Syach Putra**, with development assistance from **ChatGPT (OpenAI), OpenAI Codex, and Claude (Anthropic)**.

AI tools assisted with code analysis, debugging, implementation, testing, and documentation.
