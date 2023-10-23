namespace banka_otomasyonu
{
    partial class para_cekme
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
            this.gbparayatirma = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnParacekme = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtadSoyad = new System.Windows.Forms.TextBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbparayatirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbparayatirma
            // 
            this.gbparayatirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbparayatirma.Controls.Add(this.btnGeri);
            this.gbparayatirma.Controls.Add(this.btnParacekme);
            this.gbparayatirma.Controls.Add(this.txtTutar);
            this.gbparayatirma.Controls.Add(this.lblTutar);
            this.gbparayatirma.Controls.Add(this.txtadSoyad);
            this.gbparayatirma.Controls.Add(this.lblNameSurname);
            this.gbparayatirma.Controls.Add(this.txtId);
            this.gbparayatirma.Controls.Add(this.lblId);
            this.gbparayatirma.Location = new System.Drawing.Point(49, 42);
            this.gbparayatirma.Name = "gbparayatirma";
            this.gbparayatirma.Size = new System.Drawing.Size(504, 394);
            this.gbparayatirma.TabIndex = 3;
            this.gbparayatirma.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(53, 320);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(189, 30);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnParacekme
            // 
            this.btnParacekme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParacekme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParacekme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParacekme.Location = new System.Drawing.Point(279, 320);
            this.btnParacekme.Name = "btnParacekme";
            this.btnParacekme.Size = new System.Drawing.Size(189, 30);
            this.btnParacekme.TabIndex = 6;
            this.btnParacekme.Text = "PARA ÇEK";
            this.btnParacekme.UseVisualStyleBackColor = false;
            this.btnParacekme.Click += new System.EventHandler(this.btnParacekme_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(53, 246);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(261, 27);
            this.txtTutar.TabIndex = 5;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(49, 207);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(193, 20);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Çekilmek istenilen tutar :";
            // 
            // txtadSoyad
            // 
            this.txtadSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadSoyad.Location = new System.Drawing.Point(53, 158);
            this.txtadSoyad.Name = "txtadSoyad";
            this.txtadSoyad.Size = new System.Drawing.Size(261, 27);
            this.txtadSoyad.TabIndex = 3;
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Location = new System.Drawing.Point(49, 135);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(85, 20);
            this.lblNameSurname.TabIndex = 2;
            this.lblNameSurname.Text = "Ad Soyad:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(53, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(261, 27);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(49, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // para_cekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 482);
            this.Controls.Add(this.gbparayatirma);
            this.Name = "para_cekme";
            this.Text = "para_cekme";
            this.gbparayatirma.ResumeLayout(false);
            this.gbparayatirma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbparayatirma;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnParacekme;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtadSoyad;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}