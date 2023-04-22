using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Sohbet_Uygulaması_V3._0.Diller;

namespace Sohbet_Uygulaması_V3._0
{
    public partial class GirisSecenekleri : Form
    {
        private string ApiKey, AuthDomain;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nsol,
                int nsag,
                int nust,
                int nalt,
                int nykseklik,
                int ngenislik

            );
        public GirisSecenekleri()
        {
            InitializeComponent();
            this.ApiKey = ApiKey;
            this.AuthDomain = AuthDomain;
        }
        public void DilSec(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();      //CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            GirisYapBtn.Text = Localization.GirisYapBtn;
            KayıtOLBtn.Text = Localization.KayıtOLBtn;
            TurkeyBtn.Text = Localization.TurkeyBtn;
            EnglishBtn.Text = Localization.EnglishBtn;
            label1.Text = Localization.label1;
        }
        private void GirisSecenekleri_Load(object sender, EventArgs e)
        {
            GirisYapBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GirisYapBtn.Width, GirisYapBtn.Height, 30, 30));
            KayıtOLBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,KayıtOLBtn.Width,KayıtOLBtn.Height, 30, 30));
        }

        private void TurkeyBtn_Click(object sender, EventArgs e)
        {
            DilSec("");
        }

        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            DilSec("en-US");
        }
    }
}
