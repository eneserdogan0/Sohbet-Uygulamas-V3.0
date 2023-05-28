using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Sohbet_Uygulaması_V3._0.Base;
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
        //private MainWin mainWin;
        //private FirebaseClient istemci;
        //private UserCredential ProfilID;
        public HesabimUC()
        {
            InitializeComponent();
            //this.istemci = istemci;
            //this.ProfilID = ProfilID;
            //mainWin = new MainWin(ProfilID);
            
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

        private void HsbDGW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int secilen = e.RowIndex;
            //if(secilen == 0 )
            //{
            //    MyProfil myProfil = new MyProfil(istemci,ProfilID);
            //    myProfil.ProfileIDTB.Text = HsbDGW.Rows[secilen].Cells[0].Value.ToString();
            //    myProfil.ProfilAdTB.Text = HsbDGW.Rows[secilen].Cells[1].Value.ToString();
            //    myProfil.ProfilSydTB.Text = HsbDGW.Rows[secilen].Cells[2].Value.ToString();
            //    myProfil.ProfilUlkeTB.Text = HsbDGW.Rows[secilen].Cells[3].Value.ToString();
            //    myProfil.ProfilNoTB.Text = HsbDGW.Rows[secilen].Cells[4].Value.ToString();
            //    myProfil.ShowDialog();

            //    mainWin.Kullanicilari_Listele();
            //}
        }

        private void HesabimUC_Load(object sender, EventArgs e)
        {

        }
    }
}
