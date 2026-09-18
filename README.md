# Sistem Kependudukan Desa

Aplikasi desktop untuk mengelola data penduduk dan pengajuan surat di tingkat desa/kelurahan. Dibuat sebagai tugas mata pelajaran Pemrograman Desktop.

## Identitas

- **Nama**: Ridho Syach Putra
- **Sekolah**: SMK TI Pembangunan Cimahi
- **Jurusan**: Rekayasa Perangkat Lunak (RPL)

## Tentang Aplikasi

Sistem ini dibuat untuk membantu proses administrasi kependudukan yang biasanya masih manual, seperti pendataan warga dan pengajuan surat keterangan (domisili, usaha, pengantar KTP, dll). Ada 3 level akses (Admin, Petugas, Lurah) dengan hak akses yang berbeda-beda sesuai tanggung jawabnya masing-masing.

## Fitur

- Login dengan sistem role (Admin, Petugas, Lurah)
- CRUD data penduduk (tambah, ubah, hapus, lihat)
- Pengajuan surat oleh warga/petugas, dengan nomor surat yang digenerate otomatis
- Approval pengajuan surat oleh Lurah (setuju/tolak beserta catatan)
- Dashboard ringkasan (total penduduk, total surat per status)
- Export data ke Excel (CSV)

## Teknologi yang Dipakai

- C# WinForms (.NET Framework)
- MySQL sebagai database
- MySQL Connector/NET

## Cara Menjalankan

1. Import file `db_kependudukan.sql` ke MySQL (bisa lewat phpMyAdmin)
2. Buka `project1_ridho.sln` dengan Visual Studio
3. Sesuaikan connection string di `Koneksi.cs` kalau perlu
4. Build dan jalankan (F5)

## Struktur Project

```
project1_ridho/
├── Form1.cs                  # Halaman login
├── FormMain.cs                # Dashboard utama
├── FormPenduduk.cs            # CRUD data penduduk
├── FormTransaksiSurat.cs      # Pengajuan surat
├── FormApproval.cs            # Approval surat oleh Lurah
├── FormRole.cs                # Master data role
├── FormUser.cs                # Master data user
└── Koneksi.cs                 # Koneksi ke database
```

## Catatan

Data login untuk testing:
| Role | Username | Password |
|---|---|---|
| Admin | admin | admin123 |
| Petugas | petugas | 12345 |
| Lurah | lurah | lurah123 |

---

# Village Population Administration System

Desktop application for managing population data and letter/certificate requests at the village level. Built as a Desktop Programming coursework project.

## Identity

- **Name**: Ridho Syach Putra
- **School**: SMK TI Pembangunan Cimahi
- **Major**: Software Engineering (RPL)

## About the Application

This system was built to help population administration processes that are usually still manual, such as resident data collection and letter/certificate requests (domicile, business, ID card referral, etc.). There are 3 access levels (Admin, Staff, Village Head) each with different access rights according to their respective responsibilities.

## Features

- Login with role-based system (Admin, Staff, Village Head)
- CRUD for resident data (add, edit, delete, view)
- Letter requests submitted by residents/staff, with auto-generated letter numbers
- Letter request approval by the Village Head (approve/reject with notes)
- Summary dashboard (total residents, total letters per status)
- Export data to Excel (CSV)

## Technologies Used

- C# WinForms (.NET Framework)
- MySQL as the database
- MySQL Connector/NET

## How to Run

1. Import the `db_kependudukan.sql` file into MySQL (can be done via phpMyAdmin)
2. Open `project1_ridho.sln` with Visual Studio
3. Adjust the connection string in `Koneksi.cs` if needed
4. Build and run (F5)

## Project Structure

```
project1_ridho/
├── Form1.cs                  # Login page
├── FormMain.cs                # Main dashboard
├── FormPenduduk.cs            # Resident data CRUD
├── FormTransaksiSurat.cs      # Letter requests
├── FormApproval.cs            # Letter approval by the Village Head
├── FormRole.cs                # Role master data
├── FormUser.cs                # User master data
└── Koneksi.cs                 # Database connection
```

## Notes

Login credentials for testing:
| Role | Username | Password |
|---|---|---|
| Admin | admin | admin123 |
| Staff | petugas | 12345 |
| Village Head | lurah | lurah123 |
