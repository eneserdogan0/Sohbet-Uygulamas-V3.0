namespace Sohbet_Uygulaması_V3._0.MainWinUserController
{
    partial class GlobalSohbetUC
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MesajTB = new System.Windows.Forms.TextBox();
            this.MesajGonderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(0, 399);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 34);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "GLOBAL SOHBET";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MesajTB
            // 
            this.MesajTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MesajTB.Location = new System.Drawing.Point(0, 379);
            this.MesajTB.Name = "MesajTB";
            this.MesajTB.Size = new System.Drawing.Size(500, 20);
            this.MesajTB.TabIndex = 2;
            // 
            // MesajGonderBtn
            // 
            this.MesajGonderBtn.Location = new System.Drawing.Point(341, 405);
            this.MesajGonderBtn.Name = "MesajGonderBtn";
            this.MesajGonderBtn.Size = new System.Drawing.Size(156, 23);
            this.MesajGonderBtn.TabIndex = 3;
            this.MesajGonderBtn.Text = "Mesajı Gönder";
            this.MesajGonderBtn.UseVisualStyleBackColor = true;
            this.MesajGonderBtn.Click += new System.EventHandler(this.MesajGonderBtn_Click);
            // 
            // GlobalSohbetUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MesajGonderBtn);
            this.Controls.Add(this.MesajTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "GlobalSohbetUC";
            this.Size = new System.Drawing.Size(500, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MesajTB;
        private System.Windows.Forms.Button MesajGonderBtn;
    }
}
