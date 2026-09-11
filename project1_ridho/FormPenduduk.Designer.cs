
namespace project1_ridho
{
    partial class FormPenduduk
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
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cmbAgama = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.dgvPenduduk = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenduduk)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 55);
            this.pnlHeader.TabIndex = 14;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DATA PENDUDUK";
            //
            // txtNIK
            //
            this.txtNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIK.Location = new System.Drawing.Point(150, 72);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(250, 25);
            this.txtNIK.TabIndex = 0;
            //
            // txtNama
            //
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(150, 107);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 25);
            this.txtNama.TabIndex = 1;
            //
            // cmbJenisKelamin
            //
            this.cmbJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(150, 177);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(250, 25);
            this.cmbJenisKelamin.TabIndex = 2;
            //
            // txtAlamat
            //
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(150, 142);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(250, 25);
            this.txtAlamat.TabIndex = 3;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            //
            // cmbAgama
            //
            this.cmbAgama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgama.FormattingEnabled = true;
            this.cmbAgama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Katolik",
            "Hindu",
            "Buddha",
            "Konghucu"});
            this.cmbAgama.Location = new System.Drawing.Point(150, 212);
            this.cmbAgama.Name = "cmbAgama";
            this.cmbAgama.Size = new System.Drawing.Size(250, 25);
            this.cmbAgama.TabIndex = 4;
            //
            // dtpTanggalLahir
            //
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Location = new System.Drawing.Point(150, 247);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(250, 25);
            this.dtpTanggalLahir.TabIndex = 5;
            //
            // btnSimpan
            //
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(46))), ((int)((byte)(125))), ((int)((byte)(50))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(150, 295);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 40);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            //
            // btnUbah
            //
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(21))), ((int)((byte)(101))), ((int)((byte)(192))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(280, 295);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(120, 40);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            //
            // btnHapus
            //
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(183))), ((int)((byte)(28))), ((int)((byte)(28))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(410, 295);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(120, 40);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIK";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Lengkap";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alamat";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jenis Kelamin";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label5.Location = new System.Drawing.Point(30, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Agama";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.label6.Location = new System.Drawing.Point(30, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tanggal Lahir";
            //
            // btnKeluar
            //
            this.btnKeluar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(198))), ((int)((byte)(40))), ((int)((byte)(40))));
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(540, 295);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(120, 40);
            this.btnKeluar.TabIndex = 13;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            //
            // btnExportExcel
            //
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(66))), ((int)((byte)(66))), ((int)((byte)(66))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(660, 295);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 40);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            //
            // dgvPenduduk
            //
            this.dgvPenduduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenduduk.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.dgvPenduduk.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPenduduk.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPenduduk.EnableHeadersVisualStyles = false;
            this.dgvPenduduk.RowHeadersVisible = false;
            this.dgvPenduduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenduduk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPenduduk.Location = new System.Drawing.Point(20, 350);
            this.dgvPenduduk.Name = "dgvPenduduk";
            this.dgvPenduduk.Size = new System.Drawing.Size(740, 240);
            this.dgvPenduduk.TabIndex = 15;
            this.dgvPenduduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenduduk_CellClick);
            //
            // FormPenduduk
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(245))), ((int)((byte)(245))), ((int)((byte)(245))));
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.dgvPenduduk);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbAgama);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIK);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormPenduduk";
            this.Text = "FormPenduduk";
            this.Load += new System.EventHandler(this.FormPenduduk_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenduduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cmbAgama;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dgvPenduduk;
        private System.Windows.Forms.Button btnExportExcel;
    }
}
