using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Sohbet_Uygulaması_V3._0.BaseRenkler;
using Sohbet_Uygulaması_V3._0.DataBase_Islemleri;
using Sohbet_Uygulaması_V3._0.MainWinUserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sohbet_Uygulaması_V3._0.Base
{
    public partial class MainWin : Form
    {
        private Button SeciliButon;
        private Random random;
        private int tempDeger;
        private string renk;
        private UserCredential KullaniciID;
        private FirebaseClient firebase_Client1;
        public MainWin(UserCredential KullaniciID)
        {
            InitializeComponent();
            random = new Random();

            this.KullaniciID = KullaniciID;

            this.Text = this.Text + "  Hesap:  " + KullaniciID.User.Info.Email;
            try
            {
                firebase_Client1 = new FirebaseClient("https://sohbetuygulamasiv3eneserdogan0-default-rtdb.firebaseio.com/",
                   new FirebaseOptions
                   {
                       AuthTokenAsyncFactory = () => KullaniciID.User.GetIdTokenAsync(),
                   }

                );

                //MessageBox.Show("Realtime Database oluşturuldu ", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesajdeneme "+ex.Message,"ERROR",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
            }
        }

        private void BaseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void TesTBtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Ad = "Enes";
            kullanici1.Soyad = "Erdoğan";
            kullanici1.Ulke = "Türkiye";
            kullanici1.ID = 1;

            await firebase_Client1.Child("Kullanicilar").Child("1").PutAsync(kullanici1);

            //await firebase_Client1.Child("Kullanicilar").Child("1").DeleteAsync();


            //await firebase_Client1.Child("deneme").Child("içdeneme").PutAsync(new Dinosaur());
        }
        private Color SelectTemaRenkleri()
        {
            try
            {
                int deger = random.Next(TemaRenkleri.ColorList.Count);
                //if (deger > 0)
               // {
                    while (tempDeger == deger)
                    {
                        deger = random.Next(TemaRenkleri.ColorList.Count);
                    }
                //}
               // else
                //{
                    tempDeger = deger;
                    string renk = TemaRenkleri.ColorList[deger];

                    return ColorTranslator.FromHtml(renk);
               // }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Mesaj"+ ex.Message,"Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                return ColorTranslator.FromHtml(renk);
            }
            //return ColorTranslator.FromHtml(renk);
        }
        private void AktifButon(object Sendbtn)
        {
            if (Sendbtn != null)
            {
                if(SeciliButon != (Button)Sendbtn)
                {
                    PasifButon();
                    Color color = SelectTemaRenkleri();
                    SeciliButon = (Button)Sendbtn;
                    SeciliButon.BackColor = color;
                    SeciliButon.ForeColor = Color.White;
                    SeciliButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }
        private void PasifButon()
        {
            SelectTemaRenkleri();
           
            foreach (Control OncekiBtn in Panelbase.Controls)
            {
                if(OncekiBtn.GetType() == typeof(Button))
                {
                    OncekiBtn.BackColor = Color.FromArgb(51,51,80);
                    OncekiBtn.ForeColor = Color.Gainsboro;
                    OncekiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HesabımBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            HesabimUC hesabimUC = new HesabimUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(hesabimUC);

        }

        private void ArkadaslarımBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            ArkadaslarimUC arkadaslarimUC = new ArkadaslarimUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(arkadaslarimUC);
        }

        private void GSohbetBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            GlobalSohbetUC globalSohbetUC = new GlobalSohbetUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(globalSohbetUC);
        }

        private void VSmkPMBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            VSmokePMUC vSmokePmUC = new VSmokePMUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(vSmokePmUC);
        }

        private void AyarlarBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            AyarlarUC ayarlarUC = new AyarlarUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(ayarlarUC);
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleButton1.Checked)
            {
                this.BackColor = Color.DimGray;
                
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void Panelbase_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
