using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using LiteDB;
using Sohbet_Uygulaması_V3._0.DataBase_Islemleri;
using Sohbet_Uygulaması_V3._0.MainWinUserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private HesabimUC hesabimUC;
        private ArkadaslarimUC arkadaslarimUC;
        private Config connection;
        private string PFoto_url = "";
        public MyProfil(FirebaseClient istemci, UserCredential ProfilID)
        {
            InitializeComponent();
            connection = new Config();
            this.istemci = istemci;
            this.ProfilID = ProfilID;
            arkadaslarimUC = new ArkadaslarimUC();
            hesabimUC = new HesabimUC();
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
                kullanici1.Arkadaslarim = String.Format(PFoto_url, kullanici1);
                kullanici1.Fotograf = String.Format("Profil Fotografları/{0}/K1ProfilFoto.png",kullanici1.ID);

                if (PFoto_url != "")
                {
                    FirebaseStorage Fotografbox = new FirebaseStorage(connection.FireBaseStorage,
                                      new FirebaseStorageOptions
                                      {
                                          AuthTokenAsyncFactory = () => ProfilID.User.GetIdTokenAsync(),
                                          ThrowOnCancel = true,
                                      });

                    FileStream stream = File.Open(PFoto_url, System.IO.FileMode.Open);

                    FirebaseStorageTask gonder = Fotografbox.Child("Profil Fotografları").Child(kullanici1.ID).Child("K1ProfilFoto.png").PutAsync(stream);

                    gonder.Progress.ProgressChanged += (s, ev) => BnmProfilPB.Value = ev.Percentage;
                }                                  

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
            Kullanicilar_Table2 .Columns.Add("Arkadaşlarım",typeof(string));
            foreach (FirebaseObject<Kullanicilarr> kullanici in data)
            {
                Kullanicilar_Table2.Rows.Add(kullanici.Key, kullanici.Object.Ad, kullanici.Object.Soyad, kullanici.Object.Ulke, kullanici.Object.No,kullanici.Object.Arkadaslarim);

            }
            //arkadaslarimUC.ArkDGW.DataSource = Kullanicilar_Table2;

            //arkadaslarimUC.ArkDGW.DataSource = data;

            hesabimUC.HsbDGW.DataSource = data;

            hesabimUC.HsbDGW.DataSource = Kullanicilar_Table2;


            MessageBox.Show("veri eklendi");



        }

        private void ProfilFotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog profilfotoSec = new OpenFileDialog();

            if (profilfotoSec.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = File.Open(profilfotoSec.FileName, System.IO.FileMode.Open);

                Image fotograf = (Image)Image.FromStream(stream).Clone();
                ProfilFotoPB.Image = fotograf;
                stream.Close();

                PFoto_url = profilfotoSec.FileName;
            }
        }
    }    
}    






