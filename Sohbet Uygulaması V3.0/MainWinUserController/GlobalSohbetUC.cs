using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V3._0.MainWinUserController
{
    public partial class GlobalSohbetUC : UserControl
    {
    //    private FirebaseClient mesajistemci;
    //    private UserCredential mesajProfilID;
        public GlobalSohbetUC(FirebaseClient mesajistemci, UserCredential mesajProfilID)
        {
            InitializeComponent();
        }

        private  void MesajGonderBtn_Click(object sender, EventArgs e)
        {
            //Mesaj mesaj1 = new Mesaj();
            //mesaj1.Icerik = "deneme123";
            //mesaj1.Gonderen = "Enes";
            //string mesaj = MesajTB.Text;

            //Kullanicilarr kullanici1 = new Kullanicilarr();
            //kullanici1.Ad = "Enes";
            ////kullanici1.ID = 1;
            //kullanici1.Soyad = "Erdoğan";
            //kullanici1.Ulke = "Türkiye";
            //kullanici1.No = "532424233";

            //await firebase_Client1.Child("kullanicilar").Child("kullanici1").PutAsync(kullanici1);
            // Mesajı Firebase Realtime Database'e gönder
            //var mesajObject = new Mesaj { mesaj1.Icerik = mesaj, Gonderen = mesajProfilID.User.Info.Email };
            //await mesajistemci.Child("Kullanıcılar").Child("mesaj1").PostAsync(mesaj1);
        }
    }
}
