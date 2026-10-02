namespace project1_ridho
{
    partial class Form1
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoginDescription = new System.Windows.Forms.Label();
            this.lblLoginFooter = new System.Windows.Forms.Label();
            this.lblAdministration = new System.Windows.Forms.Label();
            this.pnlTitleAccent = new System.Windows.Forms.Panel();
            this.pnlUsernameInput = new System.Windows.Forms.Panel();
            this.pnlPasswordInput = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUsernameInput.SuspendLayout();
            this.pnlPasswordInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // panel1 - identitas dan formulir masuk
            this.panel1.BackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 520);
            this.panel1.TabIndex = 0;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblLoginDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlUsernameInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlPasswordInput);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblLoginFooter);
            // picLogo - resource asli tetap digunakan
            this.picLogo.Image = global::project1_ridho.Properties.Resources.logo_jabar;
            this.picLogo.Location = new System.Drawing.Point(64, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(64, 72);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;
            // label3
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 34);
            this.label3.Text = "SELAMAT DATANG";
            // lblLoginDescription
            this.lblLoginDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginDescription.ForeColor = System.Drawing.Color.FromArgb(225, 233, 242);
            this.lblLoginDescription.Location = new System.Drawing.Point(64, 165);
            this.lblLoginDescription.Name = "lblLoginDescription";
            this.lblLoginDescription.Size = new System.Drawing.Size(270, 46);
            this.lblLoginDescription.Text = "Silakan masuk untuk mengakses\r\nSistem Informasi Kependudukan Desa.";
            // label1
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(225, 233, 242);
            this.label1.Location = new System.Drawing.Point(64, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 18);
            this.label1.Text = "USERNAME";
            // pnlUsernameInput - ruang putih untuk padding textbox single-line
            this.pnlUsernameInput.BackColor = System.Drawing.Color.White;
            this.pnlUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsernameInput.Location = new System.Drawing.Point(64, 247);
            this.pnlUsernameInput.Name = "pnlUsernameInput";
            this.pnlUsernameInput.Size = new System.Drawing.Size(250, 38);
            this.pnlUsernameInput.TabIndex = 0;
            this.pnlUsernameInput.Controls.Add(this.textBoxUsername);
            // textBoxUsername
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.textBoxUsername.Location = new System.Drawing.Point(11, 8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(226, 18);
            this.textBoxUsername.TabIndex = 0;
            // label2
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(225, 233, 242);
            this.label2.Location = new System.Drawing.Point(64, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.Text = "PASSWORD";
            // pnlPasswordInput
            this.pnlPasswordInput.BackColor = System.Drawing.Color.White;
            this.pnlPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordInput.Location = new System.Drawing.Point(64, 328);
            this.pnlPasswordInput.Name = "pnlPasswordInput";
            this.pnlPasswordInput.Size = new System.Drawing.Size(250, 38);
            this.pnlPasswordInput.TabIndex = 1;
            this.pnlPasswordInput.Controls.Add(this.textBoxPassword);
            // textBoxPassword
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.textBoxPassword.Location = new System.Drawing.Point(11, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(226, 18);
            this.textBoxPassword.TabIndex = 0;
            // btnLogin - handler aktif tetap didaftarkan di Form1.cs
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(48, 105, 170);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 92, 151);
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(33, 79, 132);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(64, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "MASUK";
            this.btnLogin.UseVisualStyleBackColor = false;
            // lblLoginFooter
            this.lblLoginFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLoginFooter.ForeColor = System.Drawing.Color.FromArgb(225, 233, 242);
            this.lblLoginFooter.Location = new System.Drawing.Point(64, 471);
            this.lblLoginFooter.Name = "lblLoginFooter";
            this.lblLoginFooter.Size = new System.Drawing.Size(270, 20);
            this.lblLoginFooter.Text = "Sistem Informasi Kependudukan Desa";
            // panel2 - informasi layanan
            this.panel2.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel2.Location = new System.Drawing.Point(378, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 520);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = false;
            this.panel2.Controls.Add(this.lblAdministration);
            this.panel2.Controls.Add(this.pnlTitleAccent);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            // lblAdministration
            this.lblAdministration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdministration.ForeColor = System.Drawing.Color.FromArgb(92, 105, 121);
            this.lblAdministration.Location = new System.Drawing.Point(48, 130);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(426, 22);
            this.lblAdministration.Text = "Sistem Administrasi Desa";
            // pnlTitleAccent
            this.pnlTitleAccent.BackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.pnlTitleAccent.Location = new System.Drawing.Point(48, 175);
            this.pnlTitleAccent.Name = "pnlTitleAccent";
            this.pnlTitleAccent.Size = new System.Drawing.Size(44, 4);
            this.pnlTitleAccent.TabStop = false;
            // label4
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 94);
            this.label4.Text = "SISTEM INFORMASI\r\nKEPENDUDUKAN DESA";
            // label5
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(92, 105, 121);
            this.label5.Location = new System.Drawing.Point(48, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 80);
            this.label5.Text = "Kelola data kependudukan dan pelayanan administrasi desa dengan mudah, aman, dan terstruktur.";
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Sistem Informasi Kependudukan Desa";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlUsernameInput.ResumeLayout(false);
            this.pnlUsernameInput.PerformLayout();
            this.pnlPasswordInput.ResumeLayout(false);
            this.pnlPasswordInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLoginDescription;
        private System.Windows.Forms.Label lblLoginFooter;
        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Panel pnlTitleAccent;
        private System.Windows.Forms.Panel pnlUsernameInput;
        private System.Windows.Forms.Panel pnlPasswordInput;
    }
}
