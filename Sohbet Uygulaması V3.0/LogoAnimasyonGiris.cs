using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V3._0
{
    public partial class LogoAnimasyonGiris : Form
    {
        
        public LogoAnimasyonGiris()
        {
            InitializeComponent();
            
        }

        bool aksiyon = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aksiyon==false)
            {
                this.Opacity += 0.010;
            }
            if (this.Opacity == 1.0) 
            {
                 aksiyon = true;
            }
            if (aksiyon==true)
            {
                this.Opacity -= 0.010;
                if (this.Opacity == 0)
                {
                    timer1.Enabled = false;
                }
            }
        }
    }
}
