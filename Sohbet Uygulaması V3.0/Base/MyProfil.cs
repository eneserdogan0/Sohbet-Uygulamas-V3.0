using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sohbet_Uygulaması_V3._0.Base
{
    public partial class MyProfil : Form
    {
        private FirebaseClient istemci;
        private UserCredential ProfilID;
        private ArkadaslarimUC arkadaslarimUC;
        public MyProfil(FirebaseClient istemci, UserCredential ProfilID)
        {
            InitializeComponent();
            this.istemci = istemci;
            this.ProfilID = ProfilID;
            arkadaslarimUC = new ArkadaslarimUC();
        }

        private async void Hesap_Guncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilarr kullanici1 = new Kullanicilarr();
                kullanici1.Ad = ProfilAdTB.Text.Trim();
                kullanici1.ID = ProfilID.User.Info.Uid.ToString().Trim();
                kullanici1.Soyad = ProfilSydTB.Text.Trim();
                kullanici1.No = ProfilUlkeTB.Text.Trim();
                kullanici1.Ulke = ProfilNoTB.Text.Trim();

                await istemci.Child("kullanicilar").Child(kullanici1.ID).PutAsync(kullanici1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message, "UYARI", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            finally
            {
                this.Close();
            }
        }

        private async void ArkadasEkleBtn_Click(object sender, EventArgs e)
        {


            //MyProfil myProfil = new MyProfil(firebase_Client1, KullaniciID);
            var userKey = ArkadaslarımIDTB.Text;
            var data = await istemci
                .Child("kullanicilar")
                .OrderByKey()
                .EqualTo(userKey)
                .OnceAsync<Kullanicilarr>();

            DataTable Kullanicilar_Table2 = new DataTable();
            Kullanicilar_Table2.Columns.Add("KullaniciNo", typeof(string));
            Kullanicilar_Table2.Columns.Add("Ad", typeof(string));
            Kullanicilar_Table2.Columns.Add("Soyad", typeof(string));
            Kullanicilar_Table2.Columns.Add("Ulke", typeof(string));
            Kullanicilar_Table2.Columns.Add("Numara", typeof(string));
            foreach (FirebaseObject<Kullanicilarr> kullanici in data)
            {
                Kullanicilar_Table2.Rows.Add(kullanici.Key, kullanici.Object.Ad, kullanici.Object.Soyad, kullanici.Object.Ulke, kullanici.Object.No);

            }
            arkadaslarimUC.ArkDGW.DataSource = Kullanicilar_Table2;

            //arkadaslarimUC.ArkDGW.DataSource = data;


            MessageBox.Show("veri eklendi");
































        }
    }    
}    






