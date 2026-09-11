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
