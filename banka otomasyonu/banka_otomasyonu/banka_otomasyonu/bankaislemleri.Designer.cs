namespace banka_otomasyonu
{
    partial class bankaislemleri
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
            this.gbBankaislemleri = new System.Windows.Forms.GroupBox();
            this.btnDevam = new System.Windows.Forms.Button();
            this.rbMusteriler = new System.Windows.Forms.RadioButton();
            this.rbMusterisil = new System.Windows.Forms.RadioButton();
            this.rbMusteriekle = new System.Windows.Forms.RadioButton();
            this.gbBankaislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBankaislemleri
            // 
            this.gbBankaislemleri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbBankaislemleri.Controls.Add(this.btnDevam);
            this.gbBankaislemleri.Controls.Add(this.rbMusteriler);
            this.gbBankaislemleri.Controls.Add(this.rbMusterisil);
            this.gbBankaislemleri.Controls.Add(this.rbMusteriekle);
            this.gbBankaislemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBankaislemleri.Location = new System.Drawing.Point(140, 70);
            this.gbBankaislemleri.Margin = new System.Windows.Forms.Padding(4);
            this.gbBankaislemleri.Name = "gbBankaislemleri";
            this.gbBankaislemleri.Padding = new System.Windows.Forms.Padding(4);
            this.gbBankaislemleri.Size = new System.Drawing.Size(425, 320);
            this.gbBankaislemleri.TabIndex = 1;
            this.gbBankaislemleri.TabStop = false;
            this.gbBankaislemleri.Text = "Banka İşlemleri";
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(252, 264);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(154, 36);
            this.btnDevam.TabIndex = 4;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // rbMusteriler
            // 
            this.rbMusteriler.AutoSize = true;
            this.rbMusteriler.Location = new System.Drawing.Point(69, 171);
            this.rbMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.rbMusteriler.Name = "rbMusteriler";
            this.rbMusteriler.Size = new System.Drawing.Size(105, 24);
            this.rbMusteriler.TabIndex = 3;
            this.rbMusteriler.TabStop = true;
            this.rbMusteriler.Text = "Müşteriler";
            this.rbMusteriler.UseVisualStyleBackColor = true;
            // 
            // rbMusterisil
            // 
            this.rbMusterisil.AutoSize = true;
            this.rbMusterisil.Location = new System.Drawing.Point(69, 129);
            this.rbMusterisil.Margin = new System.Windows.Forms.Padding(4);
            this.rbMusterisil.Name = "rbMusterisil";
            this.rbMusterisil.Size = new System.Drawing.Size(110, 24);
            this.rbMusterisil.TabIndex = 1;
            this.rbMusterisil.TabStop = true;
            this.rbMusterisil.Text = "Müşteri Sil";
            this.rbMusterisil.UseVisualStyleBackColor = true;
            // 
            // rbMusteriekle
            // 
            this.rbMusteriekle.AutoSize = true;
            this.rbMusteriekle.Location = new System.Drawing.Point(69, 87);
            this.rbMusteriekle.Margin = new System.Windows.Forms.Padding(4);
            this.rbMusteriekle.Name = "rbMusteriekle";
            this.rbMusteriekle.Size = new System.Drawing.Size(123, 24);
            this.rbMusteriekle.TabIndex = 0;
            this.rbMusteriekle.TabStop = true;
            this.rbMusteriekle.Text = "Müşteri Ekle";
            this.rbMusteriekle.UseVisualStyleBackColor = true;
            // 
            // bankaislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 466);
            this.Controls.Add(this.gbBankaislemleri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bankaislemleri";
            this.Text = "BANKA İŞLEMLERİ";
            this.gbBankaislemleri.ResumeLayout(false);
            this.gbBankaislemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBankaislemleri;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.RadioButton rbMusteriler;
        private System.Windows.Forms.RadioButton rbMusterisil;
        private System.Windows.Forms.RadioButton rbMusteriekle;
    }
}