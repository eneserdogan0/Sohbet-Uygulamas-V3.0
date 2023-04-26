namespace Sohbet_Uygulaması_V3._0.Base
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.TesTBtn = new System.Windows.Forms.Button();
            this.Panelbase = new System.Windows.Forms.Panel();
            this.Panellogo = new System.Windows.Forms.Panel();
            this.ArkadaslarımBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Panelbase.SuspendLayout();
            this.SuspendLayout();
            // 
            // TesTBtn
            // 
            this.TesTBtn.Location = new System.Drawing.Point(554, 304);
            this.TesTBtn.Name = "TesTBtn";
            this.TesTBtn.Size = new System.Drawing.Size(190, 92);
            this.TesTBtn.TabIndex = 0;
            this.TesTBtn.Text = "DENEME OLUŞTUR";
            this.TesTBtn.UseVisualStyleBackColor = true;
            this.TesTBtn.Click += new System.EventHandler(this.TesTBtn_Click);
            // 
            // Panelbase
            // 
            this.Panelbase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.Panelbase.Controls.Add(this.button4);
            this.Panelbase.Controls.Add(this.button3);
            this.Panelbase.Controls.Add(this.button2);
            this.Panelbase.Controls.Add(this.button1);
            this.Panelbase.Controls.Add(this.ArkadaslarımBtn);
            this.Panelbase.Controls.Add(this.Panellogo);
            this.Panelbase.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelbase.Location = new System.Drawing.Point(0, 0);
            this.Panelbase.Name = "Panelbase";
            this.Panelbase.Size = new System.Drawing.Size(140, 450);
            this.Panelbase.TabIndex = 1;
            // 
            // Panellogo
            // 
            this.Panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.Panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panellogo.Location = new System.Drawing.Point(0, 0);
            this.Panellogo.Name = "Panellogo";
            this.Panellogo.Size = new System.Drawing.Size(140, 102);
            this.Panellogo.TabIndex = 0;
            this.Panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panellogo_Paint);
            // 
            // ArkadaslarımBtn
            // 
            this.ArkadaslarımBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArkadaslarımBtn.FlatAppearance.BorderSize = 0;
            this.ArkadaslarımBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArkadaslarımBtn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ArkadaslarımBtn.Image = ((System.Drawing.Image)(resources.GetObject("ArkadaslarımBtn.Image")));
            this.ArkadaslarımBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArkadaslarımBtn.Location = new System.Drawing.Point(0, 102);
            this.ArkadaslarımBtn.Name = "ArkadaslarımBtn";
            this.ArkadaslarımBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ArkadaslarımBtn.Size = new System.Drawing.Size(140, 33);
            this.ArkadaslarımBtn.TabIndex = 1;
            this.ArkadaslarımBtn.Text = "Hesabım";
            this.ArkadaslarımBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArkadaslarımBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArkadaslarımBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 135);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Arkadaşlarım";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 168);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(140, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Global Sohbet";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 201);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(140, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "VSmoke Premium";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 234);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(140, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ayarlar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panelbase);
            this.Controls.Add(this.TesTBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainWin";
            this.Text = "Virtual Smoke";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseWindow_FormClosed);
            this.Panelbase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TesTBtn;
        private System.Windows.Forms.Panel Panelbase;
        private System.Windows.Forms.Button ArkadaslarımBtn;
        private System.Windows.Forms.Panel Panellogo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}