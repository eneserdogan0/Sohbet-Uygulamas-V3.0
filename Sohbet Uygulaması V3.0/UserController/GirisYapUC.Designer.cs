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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYapUC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogKaUCTB = new System.Windows.Forms.TextBox();
            this.LogSifUCTB = new System.Windows.Forms.TextBox();
            this.GirisYapıldıBtn = new System.Windows.Forms.Button();
            this.GosterCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.YuklemePb1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // LogKaUCTB
            // 
            this.LogKaUCTB.Location = new System.Drawing.Point(162, 38);
            this.LogKaUCTB.Name = "LogKaUCTB";
            this.LogKaUCTB.Size = new System.Drawing.Size(100, 20);
            this.LogKaUCTB.TabIndex = 2;
            this.LogKaUCTB.Text = "sedeneme12329@gmail.com";
            // 
            // LogSifUCTB
            // 
            this.LogSifUCTB.Location = new System.Drawing.Point(162, 75);
            this.LogSifUCTB.Name = "LogSifUCTB";
            this.LogSifUCTB.Size = new System.Drawing.Size(100, 20);
            this.LogSifUCTB.TabIndex = 3;
            this.LogSifUCTB.Text = "deneme12";
            // 
            // GirisYapıldıBtn
            // 
            this.GirisYapıldıBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisYapıldıBtn.Location = new System.Drawing.Point(177, 101);
            this.GirisYapıldıBtn.Name = "GirisYapıldıBtn";
            this.GirisYapıldıBtn.Size = new System.Drawing.Size(75, 23);
            this.GirisYapıldıBtn.TabIndex = 4;
            this.GirisYapıldıBtn.Text = "Giriş ";
            this.GirisYapıldıBtn.UseVisualStyleBackColor = true;
            // 
            // GosterCB
            // 
            this.GosterCB.AutoSize = true;
            this.GosterCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GosterCB.Location = new System.Drawing.Point(268, 78);
            this.GosterCB.Name = "GosterCB";
            this.GosterCB.Size = new System.Drawing.Size(57, 17);
            this.GosterCB.TabIndex = 5;
            this.GosterCB.Text = "Göster";
            this.GosterCB.UseVisualStyleBackColor = true;
            this.GosterCB.CheckedChanged += new System.EventHandler(this.GosterCB_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(19, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(58, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(253, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = " Virtual Smoke Premium";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Premiuma geçersen mesela resimleri mesaj olarak atabilirsin";
            // 
            // YuklemePb1
            // 
            this.YuklemePb1.Location = new System.Drawing.Point(162, 130);
            this.YuklemePb1.Name = "YuklemePb1";
            this.YuklemePb1.Size = new System.Drawing.Size(100, 23);
            this.YuklemePb1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.YuklemePb1.TabIndex = 11;
            this.YuklemePb1.Visible = false;
            // 
            // GirisYapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YuklemePb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GosterCB);
            this.Controls.Add(this.GirisYapıldıBtn);
            this.Controls.Add(this.LogSifUCTB);
            this.Controls.Add(this.LogKaUCTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisYapUC";
            this.Size = new System.Drawing.Size(424, 333);
            this.Load += new System.EventHandler(this.GirisYapUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox GosterCB;
        public System.Windows.Forms.TextBox LogKaUCTB;
        public System.Windows.Forms.TextBox LogSifUCTB;
        public System.Windows.Forms.Button GirisYapıldıBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ProgressBar YuklemePb1;
    }
}
