namespace banka_otomasyonu
{
    partial class para_yatirma
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
            this.btnParayatirma = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lbltutar = new System.Windows.Forms.Label();
            this.txtadSoyad = new System.Windows.Forms.TextBox();
            this.lbladSoyad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbparayatirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbparayatirma
            // 
            this.gbparayatirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbparayatirma.Controls.Add(this.btnGeri);
            this.gbparayatirma.Controls.Add(this.btnParayatirma);
            this.gbparayatirma.Controls.Add(this.txtTutar);
            this.gbparayatirma.Controls.Add(this.lbltutar);
            this.gbparayatirma.Controls.Add(this.txtadSoyad);
            this.gbparayatirma.Controls.Add(this.lbladSoyad);
            this.gbparayatirma.Controls.Add(this.txtId);
            this.gbparayatirma.Controls.Add(this.lblId);
            this.gbparayatirma.Location = new System.Drawing.Point(36, 46);
            this.gbparayatirma.Name = "gbparayatirma";
            this.gbparayatirma.Size = new System.Drawing.Size(515, 372);
            this.gbparayatirma.TabIndex = 2;
            this.gbparayatirma.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(49, 285);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(214, 36);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnParayatirma
            // 
            this.btnParayatirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParayatirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParayatirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParayatirma.Location = new System.Drawing.Point(269, 285);
            this.btnParayatirma.Name = "btnParayatirma";
            this.btnParayatirma.Size = new System.Drawing.Size(214, 36);
            this.btnParayatirma.TabIndex = 6;
            this.btnParayatirma.Text = "PARA YATIR";
            this.btnParayatirma.UseVisualStyleBackColor = false;
            this.btnParayatirma.Click += new System.EventHandler(this.btnParayatirma_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(49, 231);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(261, 27);
            this.txtTutar.TabIndex = 5;
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.Location = new System.Drawing.Point(45, 208);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(193, 20);
            this.lbltutar.TabIndex = 4;
            this.lbltutar.Text = "Yatırılmak istenilen tutar:";
            // 
            // txtadSoyad
            // 
            this.txtadSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadSoyad.Location = new System.Drawing.Point(49, 159);
            this.txtadSoyad.Name = "txtadSoyad";
            this.txtadSoyad.Size = new System.Drawing.Size(261, 27);
            this.txtadSoyad.TabIndex = 3;
            // 
            // lbladSoyad
            // 
            this.lbladSoyad.AutoSize = true;
            this.lbladSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladSoyad.Location = new System.Drawing.Point(49, 136);
            this.lbladSoyad.Name = "lbladSoyad";
            this.lbladSoyad.Size = new System.Drawing.Size(85, 20);
            this.lbladSoyad.TabIndex = 2;
            this.lbladSoyad.Text = "Ad Soyad:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(49, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(261, 27);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(49, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // para_yatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 462);
            this.Controls.Add(this.gbparayatirma);
            this.Name = "para_yatirma";
            this.Text = "PARA YATIRMA";
            this.gbparayatirma.ResumeLayout(false);
            this.gbparayatirma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbparayatirma;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnParayatirma;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.TextBox txtadSoyad;
        private System.Windows.Forms.Label lbladSoyad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}