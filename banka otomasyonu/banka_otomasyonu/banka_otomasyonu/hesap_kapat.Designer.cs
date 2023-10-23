namespace banka_otomasyonu
{
    partial class hesap_kapat
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
            this.gbHesapKapat = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtadSoyad = new System.Windows.Forms.TextBox();
            this.btnhesapkapat = new System.Windows.Forms.Button();
            this.lbladSoyad = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.gbHesapKapat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHesapKapat
            // 
            this.gbHesapKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbHesapKapat.Controls.Add(this.btnGeri);
            this.gbHesapKapat.Controls.Add(this.txtadSoyad);
            this.gbHesapKapat.Controls.Add(this.btnhesapkapat);
            this.gbHesapKapat.Controls.Add(this.lbladSoyad);
            this.gbHesapKapat.Controls.Add(this.txtid);
            this.gbHesapKapat.Controls.Add(this.lblid);
            this.gbHesapKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHesapKapat.Location = new System.Drawing.Point(41, 52);
            this.gbHesapKapat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbHesapKapat.Name = "gbHesapKapat";
            this.gbHesapKapat.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbHesapKapat.Size = new System.Drawing.Size(547, 332);
            this.gbHesapKapat.TabIndex = 1;
            this.gbHesapKapat.TabStop = false;
            this.gbHesapKapat.Text = "Hesap Kapatmak İçin";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(34, 219);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(158, 32);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtadSoyad
            // 
            this.txtadSoyad.Location = new System.Drawing.Point(124, 152);
            this.txtadSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadSoyad.Name = "txtadSoyad";
            this.txtadSoyad.Size = new System.Drawing.Size(346, 34);
            this.txtadSoyad.TabIndex = 7;
            // 
            // btnhesapkapat
            // 
            this.btnhesapkapat.Location = new System.Drawing.Point(312, 219);
            this.btnhesapkapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhesapkapat.Name = "btnhesapkapat";
            this.btnhesapkapat.Size = new System.Drawing.Size(158, 32);
            this.btnhesapkapat.TabIndex = 0;
            this.btnhesapkapat.Text = "Hesabını Kapat";
            this.btnhesapkapat.UseVisualStyleBackColor = true;
            this.btnhesapkapat.Click += new System.EventHandler(this.btnhesapkapat_Click);
            // 
            // lbladSoyad
            // 
            this.lbladSoyad.AutoSize = true;
            this.lbladSoyad.Location = new System.Drawing.Point(30, 161);
            this.lbladSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladSoyad.Name = "lbladSoyad";
            this.lbladSoyad.Size = new System.Drawing.Size(106, 25);
            this.lbladSoyad.TabIndex = 6;
            this.lbladSoyad.Text = "Ad Soyad:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(124, 108);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(346, 34);
            this.txtid.TabIndex = 5;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(30, 108);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 20);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "ID:";
            // 
            // hesap_kapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.gbHesapKapat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "hesap_kapat";
            this.Text = "HESAP KAPAT";
            this.gbHesapKapat.ResumeLayout(false);
            this.gbHesapKapat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHesapKapat;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtadSoyad;
        private System.Windows.Forms.Button btnhesapkapat;
        private System.Windows.Forms.Label lbladSoyad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
    }
}