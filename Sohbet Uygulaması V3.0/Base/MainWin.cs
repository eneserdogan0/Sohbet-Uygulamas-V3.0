using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Sohbet_Uygulaması_V3._0.DataBase_Islemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V3._0.Base
{
    public partial class MainWin : Form
    {
        private UserCredential KullaniciID;
        private FirebaseClient firebase_Client1;
        public MainWin(UserCredential KullaniciID)
        {
            InitializeComponent();

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
            //kullanici1.ID = 1;

            await firebase_Client1.Child("Kullanicilar").Child("1").PutAsync(kullanici1);

            await firebase_Client1.Child("Kullanicilar").Child("1").DeleteAsync();


            //await firebase_Client1.Child("deneme").Child("içdeneme").PutAsync(new Dinosaur());
        }
    }
}
