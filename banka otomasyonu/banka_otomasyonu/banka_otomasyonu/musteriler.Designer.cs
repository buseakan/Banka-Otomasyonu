namespace banka_otomasyonu
{
    partial class musteriler
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
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvmüsteriler = new System.Windows.Forms.DataGridView();
            this.lblMusteriler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmüsteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(409, 617);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(200, 37);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvmüsteriler
            // 
            this.dgvmüsteriler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvmüsteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmüsteriler.Location = new System.Drawing.Point(37, 107);
            this.dgvmüsteriler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvmüsteriler.Name = "dgvmüsteriler";
            this.dgvmüsteriler.RowHeadersWidth = 51;
            this.dgvmüsteriler.RowTemplate.Height = 24;
            this.dgvmüsteriler.Size = new System.Drawing.Size(941, 489);
            this.dgvmüsteriler.TabIndex = 7;
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriler.Location = new System.Drawing.Point(430, 59);
            this.lblMusteriler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(125, 22);
            this.lblMusteriler.TabIndex = 6;
            this.lblMusteriler.Text = "MÜŞTERİLER";
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 690);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvmüsteriler);
            this.Controls.Add(this.lblMusteriler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "musteriler";
            this.Text = "MÜŞTERİLER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmüsteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvmüsteriler;
        private System.Windows.Forms.Label lblMusteriler;
    }
}