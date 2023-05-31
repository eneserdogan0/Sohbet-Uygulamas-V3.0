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
using Sohbet_Uygulaması_V3._0.Base;
using Firebase.Database;
using Sohbet_Uygulaması_V3._0.DataBase_Islemleri;
using Firebase.Database.Query;
using System.IO;
//using Sohbet_Uygulaması_V3._0.Base;

namespace Sohbet_Uygulaması_V3._0
{
    public partial class GirisSecenekleri : Form
    {
        private string ApiKey, AuthDomain;
        private  GirisYapUC girisyapUc;
        private  HesapOlusturUC hesapolusturUc;
        private FirebaseAuthClient client1;
        private Config connection;
        List<Image> images = new List<Image>();
        string[] DataYeri = new string[25];


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
        public GirisSecenekleri(Config connection)
        {
            InitializeComponent();
            this.ApiKey = connection.ApiKey;
            this.AuthDomain = connection.AuthDomain;
            this.connection = connection;

            DataYeri[0] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\0 - TıklanmısHali.png";
            DataYeri[1] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\1-HARF.png";
            DataYeri[2] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\2-HARD.png";
            DataYeri[3] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\3-HARF.png";
            DataYeri[4] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\4-HARF.png";
            DataYeri[5] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\5-HARF.png";
            DataYeri[6] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\6-HARF.png";
            DataYeri[7] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\7-HARF.png";
            DataYeri[8] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\8-HARF.png";
            DataYeri[9] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\9-HARF.png";
            DataYeri[10] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\10-HARF.png";
            DataYeri[11] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\11-HARF.png";
            DataYeri[12] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\12-HARF.png";
            DataYeri[13] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\13-HARF.png";
            DataYeri[14] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\14-HARF.png";
            DataYeri[15] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\15-HARF.png";
            DataYeri[16] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\16-HARF.png";
            DataYeri[17] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\17-HARF.png";
            DataYeri[18] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\18-HARF.png";
            DataYeri[19] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\19-HARF.png";
            DataYeri[20] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\20-HARF.png";
            DataYeri[21] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\21-HARF.png";
            DataYeri[22] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\22_HARF.png";
            DataYeri[23] = @"C:\Users\ASUS TUF GAMİNG\Downloads\BeyazPostluAyıdefault.PNG";





            //DataYeri[24] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\SifreAcik.png";

            //DataYeri[23] = @"C:\Users\ASUS_TUF_GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti_22_HARF.png";

            //OynatAnimasyonu();

            //DataYeri[24] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti";
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


        public GirisSecenekleri()
        {
        }

        private void OynatAnimasyonu()
        {
        //    for (int i = 0; i < 23; i++)
        //    {
        //        if (File.Exists(DataYeri[i])) // Dosya var mı kontrolü
        //        {
        //            try
        //            {
        //                Bitmap bitmap = new Bitmap(DataYeri[i]);
        //                images.Add(bitmap);
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Hata: " + ex.Message);       // Hatanın nedenini belirlemek için hata mesajını yazdırabilirsiniz.
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Dosya bulunamadı: " + DataYeri[i]);     // Dosya bulunamadıysa hata mesajı yazdırabilirsiniz..
        //        }
        //    }
        //    images.Add(Properties.Resources._22_HARF);
        }

        //private void OynatAnimasyonu()
        //{
        //    for (int i = 0; i < 23; i++)
        //    {
        //        Bitmap bitmap = new Bitmap(DataYeri[i]);
        //        images.Add(bitmap);
        //    }
        //    images.Add(Properties.Resources._22_HARF);
        //}

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
                girisyapUc.GirisYapıldıBtn.Enabled = false;
                girisyapUc.YuklemePb1.Visible = true;

                var KullaniciID = await client1.SignInWithEmailAndPasswordAsync
                                                    (girisyapUc.LogKaUCTB.Text.Trim(),
                                                    girisyapUc.LogSifUCTB.Text.Trim());

                MessageBox.Show(KullaniciID.User.Uid);

                this.Hide();
                LogoAnimasyonGiris logoanimas = new LogoAnimasyonGiris();
                logoanimas.Show();
                MainWin nesne = new MainWin(KullaniciID);
                nesne.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata Oluştu"+ex.Message,"HATA",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);

                girisyapUc.GirisYapıldıBtn.Enabled = true;

                girisyapUc.YuklemePb1.Visible = false;
            }
            finally
            {
                girisyapUc.GirisYapıldıBtn.Enabled = true;
                girisyapUc.YuklemePb1.Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length > 0 && textBox1.Text.Length <= 20)
            //{
            //    pictureBox1.Image = images[textBox1.Text.Length - 1];
            //    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            //}
            //else if (textBox1.Text.Length <= 0)
            //    pictureBox1.Image = Properties.Resources.BeyazPostluAyıdefault;
            //else
            //    pictureBox1.Image = images[22];
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //Bitmap bmpass = new Bitmap(@"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\SifreKapali.png");
            //pictureBox1.Image = bmpass;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length > 0)
            //    pictureBox1.Image = images[textBox1.Text.Length - 1];
            //else
            //    pictureBox1.Image = Properties.Resources.BeyazPostluAyıdefault;
        }

        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            DilSec("en-US");
        }
    }
}
