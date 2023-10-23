namespace banka_otomasyonu
{
    partial class islem_ekrani
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
            this.btnHesapislemleri = new System.Windows.Forms.Button();
            this.btnBankaislemleri = new System.Windows.Forms.Button();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapislemleri
            // 
            this.btnHesapislemleri.Location = new System.Drawing.Point(53, 166);
            this.btnHesapislemleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapislemleri.Name = "btnHesapislemleri";
            this.btnHesapislemleri.Size = new System.Drawing.Size(287, 63);
            this.btnHesapislemleri.TabIndex = 7;
            this.btnHesapislemleri.Text = "Hesap İşlemleri\r\n";
            this.btnHesapislemleri.UseVisualStyleBackColor = true;
            this.btnHesapislemleri.Click += new System.EventHandler(this.btnHesapislemleri_Click);
            // 
            // btnBankaislemleri
            // 
            this.btnBankaislemleri.Location = new System.Drawing.Point(53, 82);
            this.btnBankaislemleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBankaislemleri.Name = "btnBankaislemleri";
            this.btnBankaislemleri.Size = new System.Drawing.Size(287, 64);
            this.btnBankaislemleri.TabIndex = 6;
            this.btnBankaislemleri.Text = "Banka İşlemleri\r\n";
            this.btnBankaislemleri.UseVisualStyleBackColor = true;
            this.btnBankaislemleri.Click += new System.EventHandler(this.btnBankaislemleri_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHosgeldin.Location = new System.Drawing.Point(37, 67);
            this.lblHosgeldin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(250, 32);
            this.lblHosgeldin.TabIndex = 4;
            this.lblHosgeldin.Text = "Hoşgeldiniz Sayın,\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnHesapislemleri);
            this.groupBox1.Controls.Add(this.btnBankaislemleri);
            this.groupBox1.Location = new System.Drawing.Point(43, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapmak istediğiniz işlemi seçiniz.";
            // 
            // islem_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "islem_ekrani";
            this.Text = "İŞLEM EKRANI";
            this.Load += new System.EventHandler(this.islem_ekrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapislemleri;
        private System.Windows.Forms.Button btnBankaislemleri;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}