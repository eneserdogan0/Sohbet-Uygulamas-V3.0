namespace Sohbet_Uygulaması_V3._0.MainWinUserController
{
    partial class HesabimUC
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
            this.GuncelemeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HsbAdUCTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HsbSoyadUCTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HsbNoUCTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HsbUlkeUCTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HsbUserIDUCTB = new System.Windows.Forms.TextBox();
            this.HsbDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HsbDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(715, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "HESABIM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GuncelemeBtn
            // 
            this.GuncelemeBtn.Location = new System.Drawing.Point(52, 229);
            this.GuncelemeBtn.Name = "GuncelemeBtn";
            this.GuncelemeBtn.Size = new System.Drawing.Size(84, 27);
            this.GuncelemeBtn.TabIndex = 1;
            this.GuncelemeBtn.Text = "Güncelle";
            this.GuncelemeBtn.UseVisualStyleBackColor = true;
            this.GuncelemeBtn.Click += new System.EventHandler(this.GuncellemeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adım";
            // 
            // HsbAdUCTB
            // 
            this.HsbAdUCTB.Location = new System.Drawing.Point(52, 44);
            this.HsbAdUCTB.Name = "HsbAdUCTB";
            this.HsbAdUCTB.Size = new System.Drawing.Size(100, 20);
            this.HsbAdUCTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadın";
            // 
            // HsbSoyadUCTB
            // 
            this.HsbSoyadUCTB.Location = new System.Drawing.Point(67, 78);
            this.HsbSoyadUCTB.Name = "HsbSoyadUCTB";
            this.HsbSoyadUCTB.Size = new System.Drawing.Size(100, 20);
            this.HsbSoyadUCTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numara";
            // 
            // HsbNoUCTB
            // 
            this.HsbNoUCTB.Location = new System.Drawing.Point(67, 108);
            this.HsbNoUCTB.Name = "HsbNoUCTB";
            this.HsbNoUCTB.Size = new System.Drawing.Size(100, 20);
            this.HsbNoUCTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ülke";
            // 
            // HsbUlkeUCTB
            // 
            this.HsbUlkeUCTB.Location = new System.Drawing.Point(67, 140);
            this.HsbUlkeUCTB.Name = "HsbUlkeUCTB";
            this.HsbUlkeUCTB.Size = new System.Drawing.Size(100, 20);
            this.HsbUlkeUCTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kullanıcı ID";
            // 
            // HsbUserIDUCTB
            // 
            this.HsbUserIDUCTB.Location = new System.Drawing.Point(67, 179);
            this.HsbUserIDUCTB.Name = "HsbUserIDUCTB";
            this.HsbUserIDUCTB.Size = new System.Drawing.Size(100, 20);
            this.HsbUserIDUCTB.TabIndex = 11;
            // 
            // HsbDGW
            // 
            this.HsbDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HsbDGW.Location = new System.Drawing.Point(173, 33);
            this.HsbDGW.Name = "HsbDGW";
            this.HsbDGW.Size = new System.Drawing.Size(539, 349);
            this.HsbDGW.TabIndex = 12;
            this.HsbDGW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HsbDGW_CellMouseClick);
            // 
            // HesabimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HsbDGW);
            this.Controls.Add(this.HsbUserIDUCTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HsbUlkeUCTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HsbNoUCTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HsbSoyadUCTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HsbAdUCTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuncelemeBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "HesabimUC";
            this.Size = new System.Drawing.Size(715, 395);
            ((System.ComponentModel.ISupportInitialize)(this.HsbDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView HsbDGW;
        public System.Windows.Forms.TextBox HsbAdUCTB;
        public System.Windows.Forms.TextBox HsbSoyadUCTB;
        public System.Windows.Forms.TextBox HsbNoUCTB;
        public System.Windows.Forms.TextBox HsbUlkeUCTB;
        public System.Windows.Forms.TextBox HsbUserIDUCTB;
        public System.Windows.Forms.Button GuncelemeBtn;
    }
}
