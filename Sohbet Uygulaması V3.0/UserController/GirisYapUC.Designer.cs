namespace Sohbet_Uygulaması_V3._0.UserController
{
    partial class GirisYapUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GosterCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(121, 106);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(100, 20);
            this.KullaniciAdiTB.TabIndex = 2;
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(121, 143);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(100, 20);
            this.SifreTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GosterCB
            // 
            this.GosterCB.AutoSize = true;
            this.GosterCB.Location = new System.Drawing.Point(227, 146);
            this.GosterCB.Name = "GosterCB";
            this.GosterCB.Size = new System.Drawing.Size(57, 17);
            this.GosterCB.TabIndex = 5;
            this.GosterCB.Text = "Göster";
            this.GosterCB.UseVisualStyleBackColor = true;
            this.GosterCB.CheckedChanged += new System.EventHandler(this.GosterCB_CheckedChanged);
            // 
            // GirisYapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GosterCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisYapUC";
            this.Size = new System.Drawing.Size(306, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox GosterCB;
    }
}
