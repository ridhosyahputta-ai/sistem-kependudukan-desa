
namespace project1_ridho
{
    partial class FormApproval
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
            this.dgvApproval = new System.Windows.Forms.DataGridView();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnACC = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).BeginInit();
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
            this.pnlHeader.TabIndex = 4;
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
            this.lblTitle.Text = "APPROVAL PENGAJUAN SURAT";
            //
            // dgvApproval
            //
            this.dgvApproval.BackgroundColor = System.Drawing.Color.White;
            this.dgvApproval.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.dgvApproval.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApproval.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApproval.EnableHeadersVisualStyles = false;
            this.dgvApproval.RowHeadersVisible = false;
            this.dgvApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApproval.MultiSelect = false;
            this.dgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApproval.Location = new System.Drawing.Point(20, 65);
            this.dgvApproval.Name = "dgvApproval";
            this.dgvApproval.Size = new System.Drawing.Size(760, 220);
            this.dgvApproval.TabIndex = 0;
            //
            // lblCatatan
            //
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(30))), ((int)((byte)(58))), ((int)((byte)(95))));
            this.lblCatatan.Location = new System.Drawing.Point(20, 300);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(52, 17);
            this.lblCatatan.TabIndex = 5;
            this.lblCatatan.Text = "Catatan";
            //
            // txtCatatan
            //
            this.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatatan.Location = new System.Drawing.Point(20, 322);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(400, 25);
            this.txtCatatan.TabIndex = 1;
            //
            // btnACC
            //
            this.btnACC.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(46))), ((int)((byte)(125))), ((int)((byte)(50))));
            this.btnACC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACC.ForeColor = System.Drawing.Color.White;
            this.btnACC.Location = new System.Drawing.Point(20, 365);
            this.btnACC.Name = "btnACC";
            this.btnACC.Size = new System.Drawing.Size(120, 40);
            this.btnACC.TabIndex = 2;
            this.btnACC.Text = "Setujui";
            this.btnACC.UseVisualStyleBackColor = false;
            this.btnACC.FlatAppearance.BorderSize = 0;
            //
            // btnTolak
            //
            this.btnTolak.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(198))), ((int)((byte)(40))), ((int)((byte)(40))));
            this.btnTolak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolak.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTolak.ForeColor = System.Drawing.Color.White;
            this.btnTolak.Location = new System.Drawing.Point(150, 365);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(120, 40);
            this.btnTolak.TabIndex = 3;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
            this.btnTolak.FlatAppearance.BorderSize = 0;
            //
            // btnExportExcel
            //
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(66))), ((int)((byte)(66))), ((int)((byte)(66))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(630, 365);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(150, 40);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            //
            // FormApproval
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)((byte)(245))), ((int)((byte)(245))), ((int)((byte)(245))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnACC);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.dgvApproval);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormApproval";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvApproval;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnACC;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnExportExcel;
    }
}
