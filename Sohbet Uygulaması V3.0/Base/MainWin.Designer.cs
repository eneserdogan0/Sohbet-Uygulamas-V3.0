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
            this.TesTBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TesTBtn
            // 
            this.TesTBtn.Location = new System.Drawing.Point(294, 91);
            this.TesTBtn.Name = "TesTBtn";
            this.TesTBtn.Size = new System.Drawing.Size(190, 92);
            this.TesTBtn.TabIndex = 0;
            this.TesTBtn.Text = "DENEME OLUŞTUR";
            this.TesTBtn.UseVisualStyleBackColor = true;
            this.TesTBtn.Click += new System.EventHandler(this.TesTBtn_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TesTBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainWin";
            this.Text = "Virtual Smoke";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseWindow_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TesTBtn;
    }
}