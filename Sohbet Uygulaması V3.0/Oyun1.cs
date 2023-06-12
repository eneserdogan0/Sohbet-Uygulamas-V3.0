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
    public partial class Oyun1 : Form
    {
        public Random rnd = new Random();
        public int sure = 20;
        public int toplamtik = 0;
        public int isabetlitik = 0;
        public int puan = 0; 
        public Oyun1()
        {
            InitializeComponent();
        }

        private void Oyun1_Load(object sender, EventArgs e)
        {
            pnlstart.Dock = DockStyle.Fill;

            pnlsonuc.Hide();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            pnlstart.Hide();
            timersure.Interval = 1000;
            timersure.Start();
            timerLoc.Start();

            if (rbtnkolay.Checked == true)
            {
                timerLoc.Interval = 800;
            }

            if (rbtnorta.Checked == true)
            {
                timerLoc.Interval = 600;
            }

            if (rbtnzor.Checked == true)
            {
                timerLoc.Interval = 450;
            }




        }

        private void timersure_Tick(object sender, EventArgs e)
        {
           
            lblsure.Text = Convert.ToString("Süre : " + sure);

            if (sure == 0) 
            {
                timersure.Stop(); 
                timerLoc.Stop(); 

                pnlsonuc.Dock = DockStyle.Fill; 
                pnlsonuc.Show(); 

                toplamtik += isabetlitik; 
                             
                lbltoplamtik.Text = Convert.ToString("Toplam Tıklama : " + toplamtik);
                lblisabetlitik.Text = Convert.ToString("İsabetli Tıklama : " + isabetlitik);
                lblpuan.Text = Convert.ToString("Puan : " + puan);

            }

            sure--; 
                   
        }

        private void timerLoc_Tick(object sender, EventArgs e)
        {
            AyıPb.Location = new Point(Convert.ToInt32(rnd.Next(10, 700)), 
                                     Convert.ToInt32(rnd.Next(10, 250)));  
        }

        private void AyıPb_Click(object sender, EventArgs e)
        {
            isabetlitik++; 
            puan += 5; 
        }

        private void Oyun1_MouseClick(object sender, MouseEventArgs e)
        {
            toplamtik++; 

        }

        private void TekrarDeneBtn_Click(object sender, EventArgs e)
        {
            sure = 20;
            toplamtik = 0;
            isabetlitik = 0;
            puan = 0;

            rbtnkolay.Checked = true;
            pnlsonuc.Hide(); 
            pnlstart.Show(); 
           
            AyıPb.Location = new Point(350, 110);
        }

        private void lblpuan_Click(object sender, EventArgs e)
        {

        }
    }
}
