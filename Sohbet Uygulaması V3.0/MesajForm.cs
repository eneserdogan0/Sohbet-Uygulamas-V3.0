using Firebase.Auth;
using Firebase.Database;
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

namespace Sohbet_Uygulaması_V3._0
{
    public partial class MesajForm : Form
    {
        private FirebaseClient mesajistemci;
        private UserCredential mesajProfilID;
        //private HesabimUC hesabimUC;
        //private ArkadaslarimUC arkadaslarimUC;
        private Config connection;
        public MesajForm(FirebaseClient mesajistemci, UserCredential mesajProfilID)
        {
            InitializeComponent();
            connection = new Config();
            this.mesajistemci = mesajistemci;
            this.mesajProfilID = mesajProfilID;
        }

        private void MesajGonderBtnMF_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        Mesaj kullanici1 = new Mesaj();
        //        kullanici1.Ad = ProfilAdTB.Text.Trim();
        //        kullanici1.ID = ProfilID.User.Info.Uid.ToString().Trim();
        //        kullanici1.Soyad = ProfilSydTB.Text.Trim();
        //        //kullanici1.No = ProfilUlkeTB.Text.Trim();
        //        //kullanici1.Ulke = ProfilNoTB.Text.Trim();
        //        kullanici1.Icerik = textBox1.Text.Trim();
        //        //kullanici1.Arkadaslarim = String.Format(PFoto_url, kullanici1);
        //        //kullanici1.Fotograf = String.Format("Profil Fotografları/{0}/K1ProfilFoto.png", kullanici1.ID);



        //        await istemci.Child("kullanicilar").Child(kullanici1.ID).PutAsync(kullanici1);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Hata Oluştu" + ex.Message, "UYARI", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
        //    }
        //    finally
        //    {
        //        this.Close();
        //    }
        }
    }
}
