namespace Sohbet_Uygulaması_V3._0
{
    partial class Oyun1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun1));
            this.pnlstart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnzor = new System.Windows.Forms.RadioButton();
            this.rbtnorta = new System.Windows.Forms.RadioButton();
            this.rbtnkolay = new System.Windows.Forms.RadioButton();
            this.pnlsonuc = new System.Windows.Forms.Panel();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblisabetlitik = new System.Windows.Forms.Label();
            this.lbltoplamtik = new System.Windows.Forms.Label();
            this.TekrarDeneBtn = new System.Windows.Forms.Button();
            this.AyıPb = new System.Windows.Forms.PictureBox();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.timerLoc = new System.Windows.Forms.Timer(this.components);
            this.lblsure = new System.Windows.Forms.Label();
            this.pnlstart.SuspendLayout();
            this.pnlsonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AyıPb)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlstart
            // 
            this.pnlstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlstart.Controls.Add(this.label2);
            this.pnlstart.Controls.Add(this.btnstart);
            this.pnlstart.Controls.Add(this.label1);
            this.pnlstart.Controls.Add(this.rbtnzor);
            this.pnlstart.Controls.Add(this.rbtnorta);
            this.pnlstart.Controls.Add(this.rbtnkolay);
            this.pnlstart.Location = new System.Drawing.Point(0, 0);
            this.pnlstart.Name = "pnlstart";
            this.pnlstart.Size = new System.Drawing.Size(92, 450);
            this.pnlstart.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "ZORLUK SEVİYENİ SEÇ";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(295, 337);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(198, 45);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "BAŞLAT";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "OYUN 1 YETİYİ YAKALA";
            // 
            // rbtnzor
            // 
            this.rbtnzor.AutoSize = true;
            this.rbtnzor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnzor.Location = new System.Drawing.Point(457, 286);
            this.rbtnzor.Name = "rbtnzor";
            this.rbtnzor.Size = new System.Drawing.Size(56, 20);
            this.rbtnzor.TabIndex = 2;
            this.rbtnzor.TabStop = true;
            this.rbtnzor.Text = "ZOR";
            this.rbtnzor.UseVisualStyleBackColor = true;
            // 
            // rbtnorta
            // 
            this.rbtnorta.AutoSize = true;
            this.rbtnorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnorta.Location = new System.Drawing.Point(332, 286);
            this.rbtnorta.Name = "rbtnorta";
            this.rbtnorta.Size = new System.Drawing.Size(67, 20);
            this.rbtnorta.TabIndex = 1;
            this.rbtnorta.TabStop = true;
            this.rbtnorta.Text = "ORTA";
            this.rbtnorta.UseVisualStyleBackColor = true;
            // 
            // rbtnkolay
            // 
            this.rbtnkolay.AutoSize = true;
            this.rbtnkolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnkolay.Location = new System.Drawing.Point(219, 286);
            this.rbtnkolay.Name = "rbtnkolay";
            this.rbtnkolay.Size = new System.Drawing.Size(73, 20);
            this.rbtnkolay.TabIndex = 0;
            this.rbtnkolay.TabStop = true;
            this.rbtnkolay.Text = "KOLAY";
            this.rbtnkolay.UseVisualStyleBackColor = true;
            // 
            // pnlsonuc
            // 
            this.pnlsonuc.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlsonuc.Controls.Add(this.lblpuan);
            this.pnlsonuc.Controls.Add(this.lblisabetlitik);
            this.pnlsonuc.Controls.Add(this.lbltoplamtik);
            this.pnlsonuc.Controls.Add(this.TekrarDeneBtn);
            this.pnlsonuc.Location = new System.Drawing.Point(729, 0);
            this.pnlsonuc.Name = "pnlsonuc";
            this.pnlsonuc.Size = new System.Drawing.Size(71, 450);
            this.pnlsonuc.TabIndex = 1;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(116, 166);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(94, 31);
            this.lblpuan.TabIndex = 3;
            this.lblpuan.Text = "PUAN";
            this.lblpuan.Click += new System.EventHandler(this.lblpuan_Click);
            // 
            // lblisabetlitik
            // 
            this.lblisabetlitik.AutoSize = true;
            this.lblisabetlitik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisabetlitik.Location = new System.Drawing.Point(106, 115);
            this.lblisabetlitik.Name = "lblisabetlitik";
            this.lblisabetlitik.Size = new System.Drawing.Size(142, 31);
            this.lblisabetlitik.TabIndex = 2;
            this.lblisabetlitik.Text = "İSABETLİ";
            // 
            // lbltoplamtik
            // 
            this.lbltoplamtik.AutoSize = true;
            this.lbltoplamtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtik.Location = new System.Drawing.Point(106, 64);
            this.lbltoplamtik.Name = "lbltoplamtik";
            this.lbltoplamtik.Size = new System.Drawing.Size(137, 31);
            this.lbltoplamtik.TabIndex = 1;
            this.lbltoplamtik.Text = "TIKLAMA";
            // 
            // TekrarDeneBtn
            // 
            this.TekrarDeneBtn.BackgroundImage = global::Sohbet_Uygulaması_V3._0.Properties.Resources.BeyazPostluAyıdefault;
            this.TekrarDeneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TekrarDeneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarDeneBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TekrarDeneBtn.Location = new System.Drawing.Point(575, 346);
            this.TekrarDeneBtn.Name = "TekrarDeneBtn";
            this.TekrarDeneBtn.Size = new System.Drawing.Size(169, 101);
            this.TekrarDeneBtn.TabIndex = 0;
            this.TekrarDeneBtn.Text = "TEKRAR DENE";
            this.TekrarDeneBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TekrarDeneBtn.UseVisualStyleBackColor = true;
            this.TekrarDeneBtn.Click += new System.EventHandler(this.TekrarDeneBtn_Click);
            // 
            // AyıPb
            // 
            this.AyıPb.Image = ((System.Drawing.Image)(resources.GetObject("AyıPb.Image")));
            this.AyıPb.InitialImage = null;
            this.AyıPb.Location = new System.Drawing.Point(332, 75);
            this.AyıPb.Name = "AyıPb";
            this.AyıPb.Size = new System.Drawing.Size(140, 93);
            this.AyıPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AyıPb.TabIndex = 2;
            this.AyıPb.TabStop = false;
            this.AyıPb.Click += new System.EventHandler(this.AyıPb_Click);
            // 
            // timersure
            // 
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick);
            // 
            // timerLoc
            // 
            this.timerLoc.Tick += new System.EventHandler(this.timerLoc_Tick);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(310, 407);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(71, 31);
            this.lblsure.TabIndex = 3;
            this.lblsure.Text = "Süre";
            // 
            // Oyun1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.pnlsonuc);
            this.Controls.Add(this.AyıPb);
            this.Controls.Add(this.pnlstart);
            this.Name = "Oyun1";
            this.Text = "Oyun1";
            this.Load += new System.EventHandler(this.Oyun1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Oyun1_MouseClick);
            this.pnlstart.ResumeLayout(false);
            this.pnlstart.PerformLayout();
            this.pnlsonuc.ResumeLayout(false);
            this.pnlsonuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AyıPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnzor;
        private System.Windows.Forms.RadioButton rbtnorta;
        private System.Windows.Forms.RadioButton rbtnkolay;
        private System.Windows.Forms.Panel pnlsonuc;
        private System.Windows.Forms.Button TekrarDeneBtn;
        private System.Windows.Forms.PictureBox AyıPb;
        private System.Windows.Forms.Timer timersure;
        private System.Windows.Forms.Timer timerLoc;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblisabetlitik;
        private System.Windows.Forms.Label lbltoplamtik;
        private System.Windows.Forms.Label lblsure;
    }
}