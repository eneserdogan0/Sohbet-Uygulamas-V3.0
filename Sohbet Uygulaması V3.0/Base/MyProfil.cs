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
    public partial class MyProfil : Form
    {
        private FirebaseClient istemci;
        private UserCredential ProfilID;
        public MyProfil(FirebaseClient istemci, UserCredential ProfilID)
        {
            InitializeComponent();
            this.istemci = istemci;
            this.ProfilID = ProfilID;
        }

        private async void Hesap_Guncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilarr kullanici1 = new Kullanicilarr();
                kullanici1.Ad = ProfilAdTB.Text.Trim();
                kullanici1.ID = ProfilID.User.Info.Uid.Trim().ToString();
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
    }
}
