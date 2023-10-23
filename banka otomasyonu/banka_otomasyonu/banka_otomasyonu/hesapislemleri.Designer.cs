namespace banka_otomasyonu
{
    partial class hesapislemleri
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
            this.gbHesapislemleri = new System.Windows.Forms.GroupBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.rbHesabiSil = new System.Windows.Forms.RadioButton();
            this.btnDevam = new System.Windows.Forms.Button();
            this.rbBakiyeGoruntule = new System.Windows.Forms.RadioButton();
            this.rbHavale = new System.Windows.Forms.RadioButton();
            this.rbParaCekme = new System.Windows.Forms.RadioButton();
            this.rbParaYatirma = new System.Windows.Forms.RadioButton();
            this.gbHesapislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHesapislemleri
            // 
            this.gbHesapislemleri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbHesapislemleri.Controls.Add(this.btngeri);
            this.gbHesapislemleri.Controls.Add(this.rbHesabiSil);
            this.gbHesapislemleri.Controls.Add(this.btnDevam);
            this.gbHesapislemleri.Controls.Add(this.rbBakiyeGoruntule);
            this.gbHesapislemleri.Controls.Add(this.rbHavale);
            this.gbHesapislemleri.Controls.Add(this.rbParaCekme);
            this.gbHesapislemleri.Controls.Add(this.rbParaYatirma);
            this.gbHesapislemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHesapislemleri.Location = new System.Drawing.Point(53, 50);
            this.gbHesapislemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHesapislemleri.Name = "gbHesapislemleri";
            this.gbHesapislemleri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHesapislemleri.Size = new System.Drawing.Size(583, 374);
            this.gbHesapislemleri.TabIndex = 2;
            this.gbHesapislemleri.TabStop = false;
            this.gbHesapislemleri.Text = "Hesap işlemleri";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(66, 299);
            this.btngeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(188, 29);
            this.btngeri.TabIndex = 6;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = true;
            // 
            // rbHesabiSil
            // 
            this.rbHesabiSil.AutoSize = true;
            this.rbHesabiSil.Location = new System.Drawing.Point(66, 198);
            this.rbHesabiSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHesabiSil.Name = "rbHesabiSil";
            this.rbHesabiSil.Size = new System.Drawing.Size(107, 24);
            this.rbHesabiSil.TabIndex = 5;
            this.rbHesabiSil.TabStop = true;
            this.rbHesabiSil.Text = "Hesabı Sil";
            this.rbHesabiSil.UseVisualStyleBackColor = true;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(338, 299);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(188, 29);
            this.btnDevam.TabIndex = 4;
            this.btnDevam.Text = "DEVAM ET";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // rbBakiyeGoruntule
            // 
            this.rbBakiyeGoruntule.AutoSize = true;
            this.rbBakiyeGoruntule.Location = new System.Drawing.Point(66, 166);
            this.rbBakiyeGoruntule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBakiyeGoruntule.Name = "rbBakiyeGoruntule";
            this.rbBakiyeGoruntule.Size = new System.Drawing.Size(158, 24);
            this.rbBakiyeGoruntule.TabIndex = 3;
            this.rbBakiyeGoruntule.TabStop = true;
            this.rbBakiyeGoruntule.Text = "Bakiye Görüntüle";
            this.rbBakiyeGoruntule.UseVisualStyleBackColor = true;
            // 
            // rbHavale
            // 
            this.rbHavale.AutoSize = true;
            this.rbHavale.Location = new System.Drawing.Point(66, 134);
            this.rbHavale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHavale.Name = "rbHavale";
            this.rbHavale.Size = new System.Drawing.Size(82, 24);
            this.rbHavale.TabIndex = 2;
            this.rbHavale.TabStop = true;
            this.rbHavale.Text = "Havale";
            this.rbHavale.UseVisualStyleBackColor = true;
            // 
            // rbParaCekme
            // 
            this.rbParaCekme.AutoSize = true;
            this.rbParaCekme.Location = new System.Drawing.Point(66, 102);
            this.rbParaCekme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbParaCekme.Name = "rbParaCekme";
            this.rbParaCekme.Size = new System.Drawing.Size(122, 24);
            this.rbParaCekme.TabIndex = 1;
            this.rbParaCekme.TabStop = true;
            this.rbParaCekme.Text = "Para Çekme";
            this.rbParaCekme.UseVisualStyleBackColor = true;
            // 
            // rbParaYatirma
            // 
            this.rbParaYatirma.AutoSize = true;
            this.rbParaYatirma.Location = new System.Drawing.Point(66, 70);
            this.rbParaYatirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbParaYatirma.Name = "rbParaYatirma";
            this.rbParaYatirma.Size = new System.Drawing.Size(104, 24);
            this.rbParaYatirma.TabIndex = 0;
            this.rbParaYatirma.TabStop = true;
            this.rbParaYatirma.Text = "Para Yatır";
            this.rbParaYatirma.UseVisualStyleBackColor = true;
            // 
            // hesapislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 468);
            this.Controls.Add(this.gbHesapislemleri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "hesapislemleri";
            this.Text = "HESAP İŞLEMLERİ";
            this.gbHesapislemleri.ResumeLayout(false);
            this.gbHesapislemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHesapislemleri;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.RadioButton rbHesabiSil;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.RadioButton rbBakiyeGoruntule;
        private System.Windows.Forms.RadioButton rbHavale;
        private System.Windows.Forms.RadioButton rbParaCekme;
        private System.Windows.Forms.RadioButton rbParaYatirma;
    }
}