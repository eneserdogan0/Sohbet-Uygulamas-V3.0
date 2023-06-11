using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V3._0
{
    public class CizimSinifi
    {
        //Point point = new Point();
        //point.X = 0;
        //point.Y = 0;

        public int x1;
        public int x2;
        public int y1;
        public int y2;

        public Color renk = Color.Black;
        public float kalinlik = 1;
        

        public CizimSinifi(int x1, int y1, int x2, int y2) 
        {
            this.x1 = x1;
            this.x2 = x2;   
            this.y1 = y1;
            this.y2 = y2;

            
        }
        public CizimSinifi(int x1, int y1, int x2, int y2, Color renk)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.renk = renk;

        }

        public CizimSinifi(int x1, int y1, int x2, int y2, float kalinlik )
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.kalinlik = kalinlik;

        }
       
        public CizimSinifi(int x1, int y1, int x2, int y2, Color renk, float kalinlik)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.renk = renk;
            this.kalinlik = kalinlik    ;
        }
        public void Cizdir(Panel panel)
        {         
            Graphics graphics = panel.CreateGraphics();

            Pen kalem = new Pen(renk, kalinlik);

            graphics.DrawLine(kalem, x1, y1, x2, y2);
        }

    }
}
