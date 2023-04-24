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
using Sohbet_Uygulaması_V3._0.UserController;
using Firebase.Auth;
using Firebase.Auth.Providers;

namespace Sohbet_Uygulaması_V3._0
{
    public partial class GirisSecenekleri : Form
    {
        private string ApiKey, AuthDomain;
        private  GirisYapUC girisyapUc;
        private  HesapOlusturUC hesapolusturUc;
        private FirebaseAuthClient client1;

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
        public GirisSecenekleri(string ApiKey, string AuthDomain)
        {
            InitializeComponent();
            this.ApiKey = ApiKey;
            this.AuthDomain = AuthDomain;

            girisyapUc = new GirisYapUC();
            hesapolusturUc = new HesapOlusturUC();

            GirisYapBtn_Click(this, EventArgs.Empty);

            girisyapUc.GirisYapıldıBtn.Click += girisyapıldıBtn_Click;
            hesapolusturUc.HesapOlusturulduBtn.Click += HesapOlusturulduBtn_Click;

            MessageBox.Show("domain" + AuthDomain, "key" + ApiKey);

            var Config = new FirebaseAuthConfig
            { 
                    ApiKey = ApiKey,
                    AuthDomain = AuthDomain,
                    Providers = new FirebaseAuthProvider[] { new EmailProvider() },

            };
            this.client1 = new FirebaseAuthClient(Config);
        }

        private async void HesapOlusturulduBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var KullaniciID = await client1.CreateUserWithEmailAndPasswordAsync
                                                    (hesapolusturUc.CreKaUCTB.Text.Trim(),
                                                    hesapolusturUc.CreSifUCTB.Text.Trim());

                MessageBox.Show(KullaniciID.User.Uid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message, "HATA", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }

        private async void girisyapıldıBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var KullaniciID = await client1.CreateUserWithEmailAndPasswordAsync
                                                    (girisyapUc.LogKaUCTB.Text.Trim(),
                                                    girisyapUc.LogSifUCTB.Text.Trim());

                MessageBox.Show(KullaniciID.User.Uid);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata Oluştu"+ex.Message,"HATA",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
            }
            finally
            {

            }

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

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            //girisyapUc = new GirisYapUC();

            panel1.Controls.Clear();
            panel1.Controls.Add(girisyapUc);
        }

        private void KayıtOLBtn_Click(object sender, EventArgs e)
        {
            //hesapolusturUc = new HesapOlusturUC();

            panel1.Controls.Clear();
            panel1.Controls.Add(hesapolusturUc);
        }

        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            DilSec("en-US");
        }
    }
}
