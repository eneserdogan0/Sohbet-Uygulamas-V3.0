using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Sohbet_Uygulaması_V3._0.DataBase_Islemleri;
using Sohbet_Uygulaması_V3._0.UserController;
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
    public partial class HesabimUC : UserControl
    {
        //private HesapOlusturUC hesapolusturUc;
        
        //private FirebaseClient istemci;
        //private UserCredential ProfilID;
        public HesabimUC()
        {
            InitializeComponent();
            //this.istemci = istemci;
            //this.ProfilID = ProfilID;
            
        }

        private void GuncellemeBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Kullanicilarr kullanici1 = new Kullanicilarr();
            //    kullanici1.Ad = HsbAdUCTB.Text.Trim();
            //    kullanici1.ID = HsbUserIDUCTB.Text.Trim();
            //    kullanici1.Soyad = HsbSoyadUCTB.Text.Trim();
            //    kullanici1.Ulke = HsbUlkeUCTB.Text.Trim();
            //    kullanici1.No = HsbNoUCTB.Text.Trim();

            //    await istemci.Child("kullanicilar1").Child(kullanici1.No).PutAsync(kullanici1);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata Oluştu" + ex.Message, "UYARI", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            //}
            //finally
            //{

            //}    




        }
    }
}
