namespace Sohbet_Uygulaması_V3._0
{
    partial class YAZCIZBOYA
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
            this.CizgiBtn = new System.Windows.Forms.Button();
            this.YazCizPnl1 = new System.Windows.Forms.Panel();
            this.CizgiKaydır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CizgiBtn
            // 
            this.CizgiBtn.Location = new System.Drawing.Point(713, 12);
            this.CizgiBtn.Name = "CizgiBtn";
            this.CizgiBtn.Size = new System.Drawing.Size(75, 23);
            this.CizgiBtn.TabIndex = 0;
            this.CizgiBtn.Text = "Çiz";
            this.CizgiBtn.UseVisualStyleBackColor = true;
            this.CizgiBtn.Click += new System.EventHandler(this.CizgiBtn_Click);
            // 
            // YazCizPnl1
            // 
            this.YazCizPnl1.Location = new System.Drawing.Point(6, 48);
            this.YazCizPnl1.Name = "YazCizPnl1";
            this.YazCizPnl1.Size = new System.Drawing.Size(782, 390);
            this.YazCizPnl1.TabIndex = 1;
            this.YazCizPnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.YazCizPnl_Paint);
            this.YazCizPnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YazCizPnl_MouseDown);
            this.YazCizPnl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YazCizPnl_MouseMove);
            this.YazCizPnl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YazCizPnl_MouseUp);
            // 
            // CizgiKaydır
            // 
            this.CizgiKaydır.Location = new System.Drawing.Point(12, 12);
            this.CizgiKaydır.Name = "CizgiKaydır";
            this.CizgiKaydır.Size = new System.Drawing.Size(75, 23);
            this.CizgiKaydır.TabIndex = 2;
            this.CizgiKaydır.Text = "Kaydır";
            this.CizgiKaydır.UseVisualStyleBackColor = true;
            this.CizgiKaydır.Click += new System.EventHandler(this.CizgiKaydır_Click);
            // 
            // YAZCIZBOYA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CizgiKaydır);
            this.Controls.Add(this.YazCizPnl1);
            this.Controls.Add(this.CizgiBtn);
            this.Name = "YAZCIZBOYA";
            this.Text = "YAZCIZBOYA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CizgiBtn;
        private System.Windows.Forms.Panel YazCizPnl1;
        private System.Windows.Forms.Button CizgiKaydır;
    }
}