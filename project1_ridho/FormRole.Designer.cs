namespace project1_ridho
{
    partial class FormRole
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaRole = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblDaftarRole = new System.Windows.Forms.Label();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamaRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 96);
            this.pnlHeader.TabIndex = 1;
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Text = "Manajemen Role";
            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(225, 233, 242);
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Text = "Kelola daftar role untuk administrasi desa.";
            // pnlContent
            this.pnlContent.Controls.Add(this.dgvRole);
            this.pnlContent.Controls.Add(this.lblDaftarRole);
            this.pnlContent.Controls.Add(this.pnlEditor);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(960, 504);
            this.pnlContent.TabIndex = 0;
            // pnlEditor
            this.pnlEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.Controls.Add(this.label4);
            this.pnlEditor.Controls.Add(this.txtNamaRole);
            this.pnlEditor.Controls.Add(this.label3);
            this.pnlEditor.Controls.Add(this.btnSimpan);
            this.pnlEditor.Controls.Add(this.btnUbah);
            this.pnlEditor.Controls.Add(this.btnHapus);
            this.pnlEditor.Controls.Add(this.btnClear);
            this.pnlEditor.Controls.Add(this.btnKeluar);
            this.pnlEditor.Location = new System.Drawing.Point(24, 24);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(912, 184);
            this.pnlEditor.TabIndex = 0;
            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Text = "Nama Role";
            // txtNamaRole
            this.txtNamaRole.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNamaRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamaRole.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.txtNamaRole.Location = new System.Drawing.Point(20, 44);
            this.txtNamaRole.Name = "txtNamaRole";
            this.txtNamaRole.Size = new System.Drawing.Size(872, 27);
            this.txtNamaRole.TabIndex = 0;
            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(92, 105, 121);
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Text = "Pilih baris pada tabel untuk mengubah atau menghapus role.";
            // btnSimpan
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 108, 43);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(20, 120);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(104, 40);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // btnUbah
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(48, 105, 170);
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 92, 151);
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(136, 120);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(104, 40);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            // btnHapus
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(183, 45, 45);
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(158, 36, 36);
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(252, 120);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(104, 40);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 215, 227);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 249);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.btnClear.Location = new System.Drawing.Point(368, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Bersihkan";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // btnKeluar
            this.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnKeluar.BackColor = System.Drawing.Color.White;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 215, 227);
            this.btnKeluar.FlatAppearance.BorderSize = 1;
            this.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 249);
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.btnKeluar.Location = new System.Drawing.Point(788, 120);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(104, 40);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Tutup";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // lblDaftarRole
            this.lblDaftarRole.AutoSize = true;
            this.lblDaftarRole.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblDaftarRole.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.lblDaftarRole.Location = new System.Drawing.Point(24, 228);
            this.lblDaftarRole.Name = "lblDaftarRole";
            this.lblDaftarRole.Text = "Daftar Role";
            // dgvRole
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeRows = false;
            this.dgvRole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvRole.AutoGenerateColumns = false;
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.BackgroundColor = System.Drawing.Color.White;
            this.dgvRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRole.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.dgvRole.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRole.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.dgvRole.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRole.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvRole.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.dgvRole.ColumnHeadersHeight = 40;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colNamaRole });
            this.dgvRole.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvRole.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.dgvRole.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(221, 234, 249);
            this.dgvRole.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.dgvRole.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.dgvRole.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvRole.EnableHeadersVisualStyles = false;
            this.dgvRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvRole.GridColor = System.Drawing.Color.FromArgb(235, 239, 244);
            this.dgvRole.Location = new System.Drawing.Point(24, 268);
            this.dgvRole.MultiSelect = false;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.RowHeadersVisible = false;
            this.dgvRole.RowTemplate.Height = 34;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(912, 212);
            this.dgvRole.TabIndex = 1;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // colId
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colId.DataPropertyName = "ID";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 72;
            this.colId.Name = "ID";
            this.colId.ReadOnly = true;
            this.colId.Width = 96;
            // colNamaRole
            this.colNamaRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNamaRole.DataPropertyName = "Nama Role";
            this.colNamaRole.HeaderText = "Nama Role";
            this.colNamaRole.MinimumWidth = 240;
            this.colNamaRole.Name = "colNamaRole";
            this.colNamaRole.ReadOnly = true;
            // FormRole
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "FormRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manajemen Role";
            this.Load += new System.EventHandler(this.FormRole_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDaftarRole;
        private System.Windows.Forms.TextBox txtNamaRole;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamaRole;
    }
}
