# Laporan Pengajuan Surat - Crystal Reports

Hasil pemeriksaan lokal: 16 Oktober 2026.

## Lokasi dan integrasi

- Solution: `project1_ridho.sln`.
- Project: `project1_ridho/project1_ridho.csproj`.
- Form: `project1_ridho/FormLaporanSurat.cs` dan `FormLaporanSurat.Designer.cs`.
- Template: `project1_ridho/Laporan Daftar Pengajuan Surat - Desa.rpt`.
- Navigasi: tombol Transaksi Surat di `FormMain` membuka `FormTransaksiSurat`;
  satu klik tombol Laporan Pengajuan Surat mengekspor PDF dan membuka browser default.
- Helper: `project1_ridho/LaporanSuratPdf.cs`. PDF bernama unik disimpan di
  `%TEMP%/SistemKependudukanDesa/LaporanSurat`; file ekspor parsial dibersihkan bila gagal.
- FormLaporanSurat dan CrystalReportViewer tetap tersedia sebagai cadangan dalam source,
  tanpa dibuka terlebih dahulu oleh tombol laporan.
- Pada form cadangan, viewer memenuhi area form (`DockStyle.Fill`). `OnLoad` mengambil data,
  memuat template, lalu mengisi `ReportSource`. Report dan DataSet dilepas saat form ditutup.
- Template disalin otomatis ke folder output dengan `CopyToOutputDirectory=PreserveNewest`.

Laporan memakai model push: query `SELECT` melalui `Koneksi.GetKoneksi()` mengisi
DataSet dengan tabel `surat` dan `penduduk`, lalu `ReportDocument.SetDataSource`
memasok data ke Crystal Reports. Kolom `surat.nama_warga` dalam laporan diisi dari
`penduduk.nama` melalui alias SQL. Hanya surat yang memiliki pasangan NIK di
penduduk yang diambil karena query menggunakan `INNER JOIN`.
Tidak diperlukan pengaturan DSN baru untuk alur DataSet ini.

## Hasil verifikasi awal viewer

- Rebuild Debug menggunakan MSBuild milik Visual Studio 2019 Community berhasil:
  0 warning, 0 error.
- Target .NET Framework 4.7.2; konfigurasi Any CPU dengan Prefer 32-bit aktif.
- Empat referensi utama CrystalDecisions (Engine, Shared, ReportSource,
  Windows.Forms) versi assembly 13.0.4000.0 tersedia dan berhasil di-resolve.
- Runtime lokal yang diuji: versi file 13.0.32.4286 (SP32), proses pengujian 32-bit.
- Template berhasil dimuat; memiliki tabel `surat` dan `penduduk`, tanpa subreport
  maupun parameter. Nama dan tipe field cocok dengan DataSet yang disiapkan form.
- Metadata kolom database lokal diperiksa menggunakan SELECT pada
  `information_schema.COLUMNS`; tidak mengambil isi data pribadi.
- DataSet kosong dan DataSet berisi satu baris sintetis berhasil dirender menjadi
  satu halaman, diekspor ke PDF dalam memori, dan dipasang ke CrystalReportViewer.
  Data sintetis tidak disimpan ke database.
- Salinan template pada folder Debug diverifikasi sama dengan template sumber.

Pada pemeriksaan awal viewer tidak ditemukan masalah yang memerlukan perubahan
source atau template. Alur tombol kemudian diperbarui menjadi ekspor PDF langsung.
Build menghasilkan ulang artefak bin/obj.

Pengujian runtime menggunakan data sintetis dan kontrol viewer tanpa membuka
jendela interaktif. Alur login, klik menu secara manual, dan tampilan berisi data
database utama belum diuji secara interaktif. Pengujian ini tidak membuktikan
kualitas tata letak untuk seluruh variasi panjang data nyata.

## Verifikasi ekspor PDF langsung

- Build Debug VS2019 berhasil: 0 warning, 0 error.
- FormTransaksiSurat berhasil dimuat melalui DesignSurface / FormDocumentDesigner.
- Tombol laporan memiliki tepat satu handler Click aktif. Pemuatan Designer tidak
  membuat PDF. Tidak ada ekspor pada constructor atau InitializeComponent.
- Ekspor DataSet kosong dan satu baris sintetis berhasil; hasil memiliki header
  `%PDF-`. Ekspor berulang memakai nama berbeda. PDF uji dibersihkan setelah pengujian.
- Pembukaan browser memakai executable handler HTTPS Windows melalui
  [AssocQueryString](https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-assocquerystringw),
  lalu meneruskan URI file PDF sebagai argumen. Asosiasi aplikasi pembaca `.pdf`
  tidak digunakan dan pengaturan Windows tidak diubah.
- Pada komputer pengujian, asosiasi HTTPS mengembalikan OpenWith.exe, sehingga
  jalur error browser diuji: pengguna diminta mengatur browser default, sementara
  PDF yang berhasil diekspor tetap tersedia. Browser tidak diluncurkan dalam tes.
- File PDF yang tidak ditemukan menghasilkan error yang jelas.
- Seluruh pengujian perubahan ini memakai data sintetis tanpa memanggil metode
  database. Pembukaan tab Designer VS2019 dan browser secara interaktif belum diuji.

## Menjalankan melalui Visual Studio 2019

1. Pastikan layanan MySQL lokal berjalan dan database aplikasi yang sudah ada
   tersedia. Tidak perlu mengimpor ulang SQL atau menjalankan migrasi.
2. Buka `project1_ridho.sln` menggunakan Visual Studio 2019.
3. Pastikan `project1_ridho` menjadi Startup Project. Gunakan konfigurasi
   **Debug | Any CPU**; pada Project Properties > Build, **Prefer 32-bit** tetap aktif.
4. Pastikan .NET Framework 4.7.2 targeting pack dan runtime Crystal Reports 32-bit
   tersedia. Dependensi tersebut sudah berhasil dipakai pada komputer pemeriksaan.
5. Pilih **Build > Rebuild Solution**. Pastikan file
   `Laporan Daftar Pengajuan Surat - Desa.rpt` berada di `project1_ridho/bin/Debug`
   bersama executable.
6. Atur browser default untuk tautan **HTTPS** pada Settings Windows > Apps >
   Default apps. Pastikan browser mengizinkan tampilan PDF di dalam browser;
   preferensi browser yang memaksa unduhan PDF tetap mengikuti pengaturan pengguna.
7. Tekan **F5**, masuk menggunakan akun aplikasi yang sudah tersedia, lalu buka
   **Transaksi Surat** dan klik **Laporan Pengajuan Surat** sekali. Aplikasi mengambil
   data, mengekspor PDF, dan membukanya di browser tanpa menampilkan viewer terlebih dahulu.
8. Jika browser gagal dibuka, pesan error menyertakan lokasi PDF yang berhasil
   dibuat. Tombol diaktifkan kembali setelah proses selesai. File sementara yang
   berhasil dibuat dipertahankan agar browser dapat membacanya.

Jika runtime tidak dapat dimuat, periksa bahwa proses menggunakan 32-bit dan
instalasi Crystal Reports yang sama tersedia. Jika template tidak ditemukan,
periksa salinan `.rpt` di folder executable. Jika pengambilan data gagal, periksa
layanan MySQL dan konfigurasi koneksi aplikasi secara lokal tanpa membagikan
kredensial. Mengedit desain `.rpt` di Visual Studio memerlukan integrasi designer
SAP Crystal Reports; pengujian ini memverifikasi build dan runtime, bukan membuka
designer secara interaktif.

Tidak ada INSERT, UPDATE, DELETE, migrasi SQL, perubahan database, perubahan login
atau keamanan, operasi Git yang mengubah repository, maupun akses ke drive F:.
