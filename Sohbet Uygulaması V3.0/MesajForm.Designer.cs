namespace Sohbet_Uygulaması_V3._0
{
    partial class MesajForm
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
            this.MesajGonderBtnMF = new System.Windows.Forms.Button();
            this.MesajTB_MF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MesajGonderBtnMF
            // 
            this.MesajGonderBtnMF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MesajGonderBtnMF.Location = new System.Drawing.Point(0, 409);
            this.MesajGonderBtnMF.Name = "MesajGonderBtnMF";
            this.MesajGonderBtnMF.Size = new System.Drawing.Size(694, 41);
            this.MesajGonderBtnMF.TabIndex = 0;
            this.MesajGonderBtnMF.Text = "Gönder";
            this.MesajGonderBtnMF.UseVisualStyleBackColor = true;
            this.MesajGonderBtnMF.Click += new System.EventHandler(this.MesajGonderBtnMF_Click);
            // 
            // MesajTB_MF
            // 
            this.MesajTB_MF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MesajTB_MF.Location = new System.Drawing.Point(0, 365);
            this.MesajTB_MF.Multiline = true;
            this.MesajTB_MF.Name = "MesajTB_MF";
            this.MesajTB_MF.Size = new System.Drawing.Size(694, 44);
            this.MesajTB_MF.TabIndex = 1;
            // 
            // MesajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.MesajTB_MF);
            this.Controls.Add(this.MesajGonderBtnMF);
            this.Name = "MesajForm";
            this.Text = "MesajForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button MesajGonderBtnMF;
        public System.Windows.Forms.TextBox MesajTB_MF;
    }
}