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
            this.toggleButton1 = new Sohbet_Uygulaması_V3._0.ControlButonları.ToggleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renkdegis = new System.Windows.Forms.Button();
            this.YazCizPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CizgiBtn
            // 
            this.CizgiBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CizgiBtn.Location = new System.Drawing.Point(620, 12);
            this.CizgiBtn.Name = "CizgiBtn";
            this.CizgiBtn.Size = new System.Drawing.Size(168, 30);
            this.CizgiBtn.TabIndex = 0;
            this.CizgiBtn.Text = "Çiz";
            this.CizgiBtn.UseVisualStyleBackColor = false;
            this.CizgiBtn.Click += new System.EventHandler(this.CizgiBtn_Click);
            // 
            // YazCizPnl1
            // 
            this.YazCizPnl1.Controls.Add(this.toggleButton1);
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
            this.CizgiKaydır.BackColor = System.Drawing.Color.Red;
            this.CizgiKaydır.Location = new System.Drawing.Point(12, 12);
            this.CizgiKaydır.Name = "CizgiKaydır";
            this.CizgiKaydır.Size = new System.Drawing.Size(186, 30);
            this.CizgiKaydır.TabIndex = 2;
            this.CizgiKaydır.Text = "Kaydır";
            this.CizgiKaydır.UseVisualStyleBackColor = false;
            this.CizgiKaydır.Click += new System.EventHandler(this.CizgiKaydır_Click);
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(614, 341);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(92, 22);
            this.toggleButton1.TabIndex = 3;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(404, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 25);
            this.panel1.TabIndex = 5;
            // 
            // renkdegis
            // 
            this.renkdegis.Location = new System.Drawing.Point(437, 14);
            this.renkdegis.Name = "renkdegis";
            this.renkdegis.Size = new System.Drawing.Size(75, 23);
            this.renkdegis.TabIndex = 6;
            this.renkdegis.Text = "Renk";
            this.renkdegis.UseVisualStyleBackColor = true;
            this.renkdegis.Click += new System.EventHandler(this.renkdegis_Click);
            // 
            // YAZCIZBOYA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renkdegis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CizgiKaydır);
            this.Controls.Add(this.YazCizPnl1);
            this.Controls.Add(this.CizgiBtn);
            this.Name = "YAZCIZBOYA";
            this.Text = "YAZCIZBOYA";
            this.YazCizPnl1.ResumeLayout(false);
            this.YazCizPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CizgiBtn;
        private System.Windows.Forms.Panel YazCizPnl1;
        private System.Windows.Forms.Button CizgiKaydır;
        private ControlButonları.ToggleButton toggleButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button renkdegis;
    }
}