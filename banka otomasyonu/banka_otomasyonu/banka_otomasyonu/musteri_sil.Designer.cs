namespace banka_otomasyonu
{
    partial class musteri_sil
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
            this.gbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbTicari = new System.Windows.Forms.RadioButton();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelno = new System.Windows.Forms.TextBox();
            this.lblTelefonNumarasi = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMusteriBilgileri
            // 
            this.gbMusteriBilgileri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbMusteriBilgileri.Controls.Add(this.btnGeri);
            this.gbMusteriBilgileri.Controls.Add(this.btnEkle);
            this.gbMusteriBilgileri.Controls.Add(this.rbTicari);
            this.gbMusteriBilgileri.Controls.Add(this.rbBireysel);
            this.gbMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gbMusteriBilgileri.Controls.Add(this.lblCinsiyet);
            this.gbMusteriBilgileri.Controls.Add(this.txtEmail);
            this.gbMusteriBilgileri.Controls.Add(this.lblEmail);
            this.gbMusteriBilgileri.Controls.Add(this.txtAdres);
            this.gbMusteriBilgileri.Controls.Add(this.lblAdres);
            this.gbMusteriBilgileri.Controls.Add(this.txtTelno);
            this.gbMusteriBilgileri.Controls.Add(this.lblTelefonNumarasi);
            this.gbMusteriBilgileri.Controls.Add(this.txtAdSoyad);
            this.gbMusteriBilgileri.Controls.Add(this.lblAdSoyad);
            this.gbMusteriBilgileri.Controls.Add(this.txtId);
            this.gbMusteriBilgileri.Controls.Add(this.lblId);
            this.gbMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMusteriBilgileri.Location = new System.Drawing.Point(36, 38);
            this.gbMusteriBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.gbMusteriBilgileri.Name = "gbMusteriBilgileri";
            this.gbMusteriBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.gbMusteriBilgileri.Size = new System.Drawing.Size(652, 428);
            this.gbMusteriBilgileri.TabIndex = 3;
            this.gbMusteriBilgileri.TabStop = false;
            this.gbMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(200, 343);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(159, 30);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(397, 343);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(159, 30);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "SİL";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // rbTicari
            // 
            this.rbTicari.AutoSize = true;
            this.rbTicari.Location = new System.Drawing.Point(299, 310);
            this.rbTicari.Margin = new System.Windows.Forms.Padding(4);
            this.rbTicari.Name = "rbTicari";
            this.rbTicari.Size = new System.Drawing.Size(72, 24);
            this.rbTicari.TabIndex = 13;
            this.rbTicari.TabStop = true;
            this.rbTicari.Text = "Ticari";
            this.rbTicari.UseVisualStyleBackColor = true;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(200, 310);
            this.rbBireysel.Margin = new System.Windows.Forms.Padding(4);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(91, 24);
            this.rbBireysel.TabIndex = 12;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Female ",
            "Male",
            "I don\'t want to specify."});
            this.cmbCinsiyet.Location = new System.Drawing.Point(200, 227);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(356, 28);
            this.cmbCinsiyet.TabIndex = 11;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(36, 227);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Padding = new System.Windows.Forms.Padding(5);
            this.lblCinsiyet.Size = new System.Drawing.Size(84, 30);
            this.lblCinsiyet.TabIndex = 10;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 263);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 263);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(5);
            this.lblEmail.Size = new System.Drawing.Size(66, 30);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(200, 192);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(356, 27);
            this.txtAdres.TabIndex = 7;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(36, 192);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new System.Windows.Forms.Padding(5);
            this.lblAdres.Size = new System.Drawing.Size(68, 30);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres:";
            // 
            // txtTelno
            // 
            this.txtTelno.Location = new System.Drawing.Point(200, 157);
            this.txtTelno.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelno.Name = "txtTelno";
            this.txtTelno.Size = new System.Drawing.Size(356, 27);
            this.txtTelno.TabIndex = 5;
            // 
            // lblTelefonNumarasi
            // 
            this.lblTelefonNumarasi.AutoSize = true;
            this.lblTelefonNumarasi.Location = new System.Drawing.Point(36, 157);
            this.lblTelefonNumarasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonNumarasi.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblTelefonNumarasi.Name = "lblTelefonNumarasi";
            this.lblTelefonNumarasi.Padding = new System.Windows.Forms.Padding(5);
            this.lblTelefonNumarasi.Size = new System.Drawing.Size(156, 30);
            this.lblTelefonNumarasi.TabIndex = 4;
            this.lblTelefonNumarasi.Text = "Telefon Numarası:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(200, 122);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(356, 27);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(36, 122);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Padding = new System.Windows.Forms.Padding(5);
            this.lblAdSoyad.Size = new System.Drawing.Size(95, 30);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(200, 87);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(356, 27);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 89);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.MinimumSize = new System.Drawing.Size(4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(4, 3, 5, 2);
            this.lblId.Size = new System.Drawing.Size(40, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // musteri_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 517);
            this.Controls.Add(this.gbMusteriBilgileri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "musteri_sil";
            this.Text = "MÜŞTERİ SİLME ";
            this.gbMusteriBilgileri.ResumeLayout(false);
            this.gbMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMusteriBilgileri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbTicari;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTelno;
        private System.Windows.Forms.Label lblTelefonNumarasi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}