namespace Sohbet_Uygulaması_V3._0
{
    partial class GirisSecenekleri
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSecenekleri));
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.KayıtOLBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TurkeyBtn = new System.Windows.Forms.Button();
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.BackColor = System.Drawing.Color.Cyan;
            this.GirisYapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisYapBtn.FlatAppearance.BorderSize = 0;
            this.GirisYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisYapBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisYapBtn.Location = new System.Drawing.Point(37, 12);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(128, 41);
            this.GirisYapBtn.TabIndex = 0;
            this.GirisYapBtn.Text = "Giriş Yap";
            this.GirisYapBtn.UseVisualStyleBackColor = false;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // KayıtOLBtn
            // 
            this.KayıtOLBtn.BackColor = System.Drawing.Color.Orange;
            this.KayıtOLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayıtOLBtn.FlatAppearance.BorderSize = 0;
            this.KayıtOLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayıtOLBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtOLBtn.Location = new System.Drawing.Point(314, 12);
            this.KayıtOLBtn.Name = "KayıtOLBtn";
            this.KayıtOLBtn.Size = new System.Drawing.Size(128, 41);
            this.KayıtOLBtn.TabIndex = 1;
            this.KayıtOLBtn.Text = "Kayıt OL";
            this.KayıtOLBtn.UseVisualStyleBackColor = false;
            this.KayıtOLBtn.Click += new System.EventHandler(this.KayıtOLBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TurkeyBtn
            // 
            this.TurkeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkeyBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TurkeyBtn.Image = ((System.Drawing.Image)(resources.GetObject("TurkeyBtn.Image")));
            this.TurkeyBtn.Location = new System.Drawing.Point(385, 319);
            this.TurkeyBtn.Name = "TurkeyBtn";
            this.TurkeyBtn.Size = new System.Drawing.Size(75, 32);
            this.TurkeyBtn.TabIndex = 2;
            this.TurkeyBtn.Text = "TR";
            this.TurkeyBtn.UseVisualStyleBackColor = true;
            this.TurkeyBtn.Click += new System.EventHandler(this.TurkeyBtn_Click);
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnglishBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnglishBtn.Image = ((System.Drawing.Image)(resources.GetObject("EnglishBtn.Image")));
            this.EnglishBtn.Location = new System.Drawing.Point(314, 319);
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.Size = new System.Drawing.Size(75, 32);
            this.EnglishBtn.TabIndex = 3;
            this.EnglishBtn.Text = "EN";
            this.EnglishBtn.UseVisualStyleBackColor = true;
            this.EnglishBtn.Click += new System.EventHandler(this.EnglishBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Merhaba";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 231);
            this.panel1.TabIndex = 5;
            // 
            // GirisSecenekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnglishBtn);
            this.Controls.Add(this.TurkeyBtn);
            this.Controls.Add(this.KayıtOLBtn);
            this.Controls.Add(this.GirisYapBtn);
            this.Name = "GirisSecenekleri";
            this.Text = "Giris Seçenekleri";
            this.Load += new System.EventHandler(this.GirisSecenekleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.Button KayıtOLBtn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button TurkeyBtn;
        private System.Windows.Forms.Button EnglishBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

