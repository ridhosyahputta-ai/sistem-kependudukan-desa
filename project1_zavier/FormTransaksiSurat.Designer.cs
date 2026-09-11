
namespace project1_ridho
{
    partial class FormTransaksiSurat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNoSurat = new System.Windows.Forms.Label();
            this.txtNoSurat = new System.Windows.Forms.TextBox();
            this.lblNIK = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.lblNamaWarga = new System.Windows.Forms.Label();
            this.txtNamaWarga = new System.Windows.Forms.TextBox();
            this.lblJenisSurat = new System.Windows.Forms.Label();
            this.cmbJenisSurat = new System.Windows.Forms.ComboBox();
            this.lblTanggalPengajuan = new System.Windows.Forms.Label();
            this.dtpTanggalPengajuan = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dgvTransaksiSurat = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksiSurat)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 55);
            this.pnlHeader.TabIndex = 13;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PENGAJUAN SURAT";
            //
            // lblNoSurat
            //
            this.lblNoSurat.AutoSize = true;
            this.lblNoSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSurat.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblNoSurat.Location = new System.Drawing.Point(30, 75);
            this.lblNoSurat.Name = "lblNoSurat";
            this.lblNoSurat.Size = new System.Drawing.Size(59, 17);
            this.lblNoSurat.TabIndex = 1;
            this.lblNoSurat.Text = "No. Surat";
            //
            // txtNoSurat
            //
            this.txtNoSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSurat.Location = new System.Drawing.Point(170, 72);
            this.txtNoSurat.Name = "txtNoSurat";
            this.txtNoSurat.ReadOnly = true;
            this.txtNoSurat.Size = new System.Drawing.Size(330, 25);
            this.txtNoSurat.TabIndex = 2;
            this.txtNoSurat.TabStop = false;
            //
            // lblNIK
            //
            this.lblNIK.AutoSize = true;
            this.lblNIK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIK.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblNIK.Location = new System.Drawing.Point(30, 110);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(28, 17);
            this.lblNIK.TabIndex = 3;
            this.lblNIK.Text = "NIK";
            //
            // txtNIK
            //
            this.txtNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIK.Location = new System.Drawing.Point(170, 107);
            this.txtNIK.MaxLength = 16;
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(330, 25);
            this.txtNIK.TabIndex = 4;
            //
            // lblNamaWarga
            //
            this.lblNamaWarga.AutoSize = true;
            this.lblNamaWarga.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaWarga.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblNamaWarga.Location = new System.Drawing.Point(30, 145);
            this.lblNamaWarga.Name = "lblNamaWarga";
            this.lblNamaWarga.Size = new System.Drawing.Size(79, 17);
            this.lblNamaWarga.TabIndex = 5;
            this.lblNamaWarga.Text = "Nama Warga";
            //
            // txtNamaWarga
            //
            this.txtNamaWarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaWarga.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaWarga.Location = new System.Drawing.Point(170, 142);
            this.txtNamaWarga.Name = "txtNamaWarga";
            this.txtNamaWarga.Size = new System.Drawing.Size(330, 25);
            this.txtNamaWarga.TabIndex = 6;
            //
            // lblJenisSurat
            //
            this.lblJenisSurat.AutoSize = true;
            this.lblJenisSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisSurat.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblJenisSurat.Location = new System.Drawing.Point(30, 180);
            this.lblJenisSurat.Name = "lblJenisSurat";
            this.lblJenisSurat.Size = new System.Drawing.Size(69, 17);
            this.lblJenisSurat.TabIndex = 7;
            this.lblJenisSurat.Text = "Jenis Surat";
            //
            // cmbJenisSurat
            //
            this.cmbJenisSurat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisSurat.FormattingEnabled = true;
            this.cmbJenisSurat.Items.AddRange(new object[] {
            "Surat Keterangan Domisili",
            "Surat Keterangan Usaha",
            "Surat Keterangan Tidak Mampu",
            "Surat Pengantar KTP",
            "Surat Keterangan Kelahiran",
            "Surat Keterangan Kematian",
            "Surat Pengantar Nikah",
            "Surat Keterangan Pindah"});
            this.cmbJenisSurat.Location = new System.Drawing.Point(170, 177);
            this.cmbJenisSurat.Name = "cmbJenisSurat";
            this.cmbJenisSurat.Size = new System.Drawing.Size(330, 25);
            this.cmbJenisSurat.TabIndex = 8;
            //
            // lblTanggalPengajuan
            //
            this.lblTanggalPengajuan.AutoSize = true;
            this.lblTanggalPengajuan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPengajuan.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblTanggalPengajuan.Location = new System.Drawing.Point(30, 215);
            this.lblTanggalPengajuan.Name = "lblTanggalPengajuan";
            this.lblTanggalPengajuan.Size = new System.Drawing.Size(107, 17);
            this.lblTanggalPengajuan.TabIndex = 9;
            this.lblTanggalPengajuan.Text = "Tanggal Pengajuan";
            //
            // dtpTanggalPengajuan
            //
            this.dtpTanggalPengajuan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalPengajuan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalPengajuan.Location = new System.Drawing.Point(170, 212);
            this.dtpTanggalPengajuan.Name = "dtpTanggalPengajuan";
            this.dtpTanggalPengajuan.Size = new System.Drawing.Size(330, 25);
            this.dtpTanggalPengajuan.TabIndex = 10;
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(46))), ((int)((byte)(125))), ((int)((byte)(50))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(170, 260);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 40);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            //
            // btnUbah
            //
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(21))), ((int)((byte)(101))), ((int)((byte)(192))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(300, 260);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(120, 40);
            this.btnUbah.TabIndex = 15;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            //
            // btnHapus
            //
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(183))), ((int)((byte)(28))), ((int)((byte)(28))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(430, 260);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(120, 40);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            //
            // btnKeluar
            //
            this.btnKeluar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(198))), ((int)((byte)(40))), ((int)((byte)(40))));
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(560, 260);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(120, 40);
            this.btnKeluar.TabIndex = 12;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            //
            // dgvTransaksiSurat
            //
            this.dgvTransaksiSurat.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksiSurat.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.dgvTransaksiSurat.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransaksiSurat.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaksiSurat.EnableHeadersVisualStyles = false;
            this.dgvTransaksiSurat.RowHeadersVisible = false;
            this.dgvTransaksiSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksiSurat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaksiSurat.Location = new System.Drawing.Point(30, 315);
            this.dgvTransaksiSurat.Name = "dgvTransaksiSurat";
            this.dgvTransaksiSurat.Size = new System.Drawing.Size(700, 270);
            this.dgvTransaksiSurat.TabIndex = 14;
            //
            // FormTransaksiSurat
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(245))), ((int)((byte)(245))), ((int)((byte)(245))));
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(this.dgvTransaksiSurat);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dtpTanggalPengajuan);
            this.Controls.Add(this.lblTanggalPengajuan);
            this.Controls.Add(this.cmbJenisSurat);
            this.Controls.Add(this.lblJenisSurat);
            this.Controls.Add(this.txtNamaWarga);
            this.Controls.Add(this.lblNamaWarga);
            this.Controls.Add(this.txtNIK);
            this.Controls.Add(this.lblNIK);
            this.Controls.Add(this.txtNoSurat);
            this.Controls.Add(this.lblNoSurat);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormTransaksiSurat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pengajuan Surat";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksiSurat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNoSurat;
        private System.Windows.Forms.TextBox txtNoSurat;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.Label lblNamaWarga;
        private System.Windows.Forms.TextBox txtNamaWarga;
        private System.Windows.Forms.Label lblJenisSurat;
        private System.Windows.Forms.ComboBox cmbJenisSurat;
        private System.Windows.Forms.Label lblTanggalPengajuan;
        private System.Windows.Forms.DateTimePicker dtpTanggalPengajuan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dgvTransaksiSurat;
    }
}
