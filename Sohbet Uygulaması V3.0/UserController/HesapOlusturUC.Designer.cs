namespace Sohbet_Uygulaması_V3._0.UserController
{
    partial class HesapOlusturUC
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
            this.HesapOlusturulduBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HesapOlusturulduBtn
            // 
            this.HesapOlusturulduBtn.Location = new System.Drawing.Point(153, 178);
            this.HesapOlusturulduBtn.Name = "HesapOlusturulduBtn";
            this.HesapOlusturulduBtn.Size = new System.Drawing.Size(101, 31);
            this.HesapOlusturulduBtn.TabIndex = 0;
            this.HesapOlusturulduBtn.Text = "Hesap Oluştur";
            this.HesapOlusturulduBtn.UseVisualStyleBackColor = true;
            // 
            // HesapOlusturUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HesapOlusturulduBtn);
            this.Name = "HesapOlusturUC";
            this.Size = new System.Drawing.Size(414, 273);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HesapOlusturulduBtn;
    }
}
