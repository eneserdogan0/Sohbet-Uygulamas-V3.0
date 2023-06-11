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
    public partial class YAZCIZBOYA : Form
    {
        public CizimSinifi nesne1;

        public bool ciziliyor = false;
        public List<CizimSinifi> cizgiler = new List<CizimSinifi>();

        public YAZCIZBOYA()
        {
            InitializeComponent();
        }

        private void CizgiBtn_Click(object sender, EventArgs e)
        {

            CizgiBtn.Enabled = false;
            CizimSinifi nesne1 = new CizimSinifi(0,0,0,0);
            cizgiler.Add(nesne1);
            

        }

        private void YazCizPnl_Paint(object sender, PaintEventArgs e)
        {
            foreach (CizimSinifi item in cizgiler)
            {
                item.Cizdir(YazCizPnl1);
            }
           
        }

        private void CizgiKaydır_Click(object sender, EventArgs e)
        {

            //if (nesne1!=null)
            //{
            //    nesne1.y1 = 200;
            //    YazCizPnl1.Refresh();
            //}
            //if(cizimSinifi != null)
            //{
            //    cizimSinifi.y1 = 250;
            //    //cizimSinifi.x2 = 250;
            //    //cizimSinifi.y1 = 350;
            //    //cizimSinifi.y2 = 450;
            //    YazCizPnl.Refresh();
            //}
        }

        private void YazCizPnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CizgiBtn.Enabled)
            {
                CizimSinifi son_deger = cizgiler[cizgiler.Count - 1];
                son_deger.x1 = e.X;
                son_deger.y1 = e.Y;
                ciziliyor = true;
            }
        }

        private void YazCizPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!CizgiBtn.Enabled)
            {
                CizimSinifi son_deger = cizgiler[cizgiler.Count - 1];
                son_deger.x2 = e.X;
                son_deger.y2 = e.Y;
                YazCizPnl1.Refresh();
            }
        }

        private void YazCizPnl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!CizgiBtn.Enabled)
            {
                CizimSinifi son_deger = cizgiler[cizgiler.Count - 1];
                son_deger.x2 = e.X;
                son_deger.y2 = e.Y;
                YazCizPnl1.Refresh();
                ciziliyor = false;
            }
        }
    }
}
