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
            this.ArkDGW = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArkIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArkDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // ArkDGW
            // 
            this.ArkDGW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArkDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArkDGW.Location = new System.Drawing.Point(303, 32);
            this.ArkDGW.Name = "ArkDGW";
            this.ArkDGW.Size = new System.Drawing.Size(515, 369);
            this.ArkDGW.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arkadaş Eklemek için ID Bilgisini Giriniz";
            // 
            // ArkIDTB
            // 
            this.ArkIDTB.Location = new System.Drawing.Point(102, 201);
            this.ArkIDTB.Name = "ArkIDTB";
            this.ArkIDTB.Size = new System.Drawing.Size(100, 20);
            this.ArkIDTB.TabIndex = 3;
            // 
            // ArkadaslarimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArkIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ArkDGW);
            this.Name = "ArkadaslarimUC";
            this.Size = new System.Drawing.Size(818, 401);
            ((System.ComponentModel.ISupportInitialize)(this.ArkDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView ArkDGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArkIDTB;
    }
}
