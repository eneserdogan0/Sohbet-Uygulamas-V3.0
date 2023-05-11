namespace Sohbet_Uygulaması_V3._0.MainWinUserController
{
    partial class ArkadaslarimUC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGVArkadas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVArkadas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGVArkadas
            // 
            this.DataGVArkadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVArkadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGVArkadas.Location = new System.Drawing.Point(0, 32);
            this.DataGVArkadas.Name = "DataGVArkadas";
            this.DataGVArkadas.Size = new System.Drawing.Size(818, 369);
            this.DataGVArkadas.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(818, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ARKADAŞLARIM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ArkadaslarimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGVArkadas);
            this.Name = "ArkadaslarimUC";
            this.Size = new System.Drawing.Size(818, 401);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVArkadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView DataGVArkadas;
    }
}
