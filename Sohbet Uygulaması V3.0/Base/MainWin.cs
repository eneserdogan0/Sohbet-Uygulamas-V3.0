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
using System.Runtime.InteropServices;
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
        private HesabimUC hesabimUc;
        //private Control arkadaslarimUc;

        private Config connection;

        private ArkadaslarimUC arkadaslarimUc;
        //private GlobalSohbetUC globalSohbetUc;
        //private VSmokePMUC vSmokeUc;
        //private AyarlarUC ayarlarUc;

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
        public MainWin(UserCredential KullaniciID)
        {
            InitializeComponent();
            random = new Random();
            connection = new Config();
            

            this.KullaniciID = KullaniciID;

            hesabimUc = new HesabimUC();
            arkadaslarimUc = new ArkadaslarimUC();
            //globalSohbetUc = new GlobalSohbetUC();
            //vSmokeUc = new VSmokePMUC();
            //ayarlarUc = new AyarlarUC();

            

            this.Text = this.Text + "  Hesap:  " + KullaniciID.User.Info.Email;
            try
            {
                firebase_Client1 = new FirebaseClient(connection.FBRealtimeDataBase,
                   new FirebaseOptions
                   {
                       AuthTokenAsyncFactory = () => KullaniciID.User.GetIdTokenAsync(),
                   }
                   
                );

                Kullanicilari_Listele();
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

        private void TesTBtn_Click(object sender, EventArgs e)
        {

            MyProfil myProfil = new MyProfil(firebase_Client1, KullaniciID);   //as FirebaseClient
            myProfil.ShowDialog();
            //hesabimUc = new HesabimUC(firebase_Client1,KullaniciID);
            //hesabimUc.Show();

            Kullanicilari_Listele();




            //Kullanicilarr kullanici1 = new Kullanicilarr();
            //kullanici1.Ad = "Enes";
            ////kullanici1.ID = 1;
            //kullanici1.Soyad = "Erdoğan";
            //kullanici1.Ulke = "Türkiye";
            //kullanici1.No = "532424233";
       
            //await firebase_Client1.Child("kullanicilar").Child("kullanici1").PutAsync(kullanici1);
            

            ////await firebase_Client1.Child("Kullanicilar").Child("1").DeleteAsync();


            ////await firebase_Client1.Child("deneme").Child("içdeneme").PutAsync(new Dinosaur());
        }

        public async void Kullanicilari_Listele()
        {
            var dene = await firebase_Client1.Child("kullanicilar").OrderByKey().OnceAsync<Kullanicilarr>();


            //dataGridView1.DataSource = await firebase_Client1.Child("dene1123").OnceAsync<Kullanicilarr>();
            DataTable Kullanicilar_Table = new DataTable();
            Kullanicilar_Table.Columns.Add("KullaniciNo", typeof(string));
            Kullanicilar_Table.Columns.Add("Ad", typeof(string));
            Kullanicilar_Table.Columns.Add("Soyad", typeof(string));
            Kullanicilar_Table.Columns.Add("Ulke", typeof(string));
            Kullanicilar_Table.Columns.Add("Numara", typeof(string));
            //arkadaslarimUc.DataGVArkadas.DataSource = Kullanicilar_Table;
            foreach (FirebaseObject<Kullanicilarr> kullanici in dene)
            {
                Kullanicilar_Table.Rows.Add(kullanici.Key, kullanici.Object.Ad, kullanici.Object.Soyad,kullanici.Object.Ulke, kullanici.Object.No);

            }
            //hesabimUc.HsbDGW.DataSource = Kullanicilar_Table;
            MainWDGW.DataSource = Kullanicilar_Table;
            //arkadaslarimUc.ArkDGW.DataSource = Kullanicilar_Table;

        }

        public  void Kullanicilari_Listele2()
        {
        //    MyProfil myProfil = new MyProfil(firebase_Client1,KullaniciID);
        //    var userKey = myProfil.ArkadaslarımIDTB.Text;
        //    var data = await firebase_Client1
        //        .Child("kullanicilar")
        //        .OrderByKey()
        //        .EqualTo(userKey)
        //        .OnceAsync<Kullanicilarr>();

        //    DataTable Kullanicilar_Table2 = new DataTable();
        //    Kullanicilar_Table2.Columns.Add("KullaniciNo", typeof(string));
        //    Kullanicilar_Table2.Columns.Add("Ad", typeof(string));
        //    Kullanicilar_Table2.Columns.Add("Soyad", typeof(string));
        //    Kullanicilar_Table2.Columns.Add("Ulke", typeof(string));
        //    Kullanicilar_Table2.Columns.Add("Numara", typeof(string));
        //    foreach (FirebaseObject<Kullanicilarr> user in data)
        //    {
        //        Kullanicilar_Table2.Rows.Add(user.Key, user.Object.Ad, user.Object.Soyad, user.Object.Ulke, user.Object.No);

        //    }
        //    arkadaslarimUc.ArkDGW.DataSource = Kullanicilar_Table2;
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
                //else
                //{
                //    HesabimBtn_Click(this, EventArgs.Empty);
                //}


            }
            //else
            //{
            //    HesabimBtn_Click(this, EventArgs.Empty);
            //}
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

        private void HesabimBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            //HesabimUC hesabimUC = new HesabimUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(hesabimUc);

        }

        private void ArkadaslarimBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            ArkadaslarimUC arkadaslarimUC = new ArkadaslarimUC();
            MWPanel.Controls.Clear();
            MWPanel.Controls.Add(arkadaslarimUc);

            //IReadOnlyCollection<FirebaseObject<Kullanicilar>> kullanici1 = await firebase_Client1.Child("Kullanici").OrderByKey().OnceAsync<Kullanicilar>();

            //DataTable Kullanicilar_Table = new DataTable();
            //Kullanicilar_Table.Columns.Add("Ad", typeof(string));
            //Kullanicilar_Table.Columns.Add("Soyad", typeof(string));
            //Kullanicilar_Table.Columns.Add("ID", typeof(string));
            //Kullanicilar_Table.Columns.Add("Ulke", typeof(string));
            //arkadaslarimUc.DataGVArkadas.DataSource = Kullanicilar_Table;
            //foreach (FirebaseObject<Kullanicilar> kullanici in kullanici1)
            //{
            //    Kullanicilar_Table.Rows.Add(kullanici.Key, kullanici.Object.Ad, kullanici.Object.Soyad, kullanici.Object.Ulke);

            //}
        }

        private void GSohbetBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            //GlobalSohbetUC globalSohbetUC = new GlobalSohbetUC();
            MWPanel.Controls.Clear();
            //MWPanel.Controls.Add(globalSohbetUc);
        }

        private void VSmkPMBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            //VSmokePMUC vSmokePmUC = new VSmokePMUC();
            MWPanel.Controls.Clear();
            //MWPanel.Controls.Add(vSmokeUc);
        }

        private void AyarlarBtn_Click(object sender, EventArgs e)
        {
            AktifButon(sender);
            //AyarlarUC ayarlarUC = new AyarlarUC();
            MWPanel.Controls.Clear();
            //MWPanel.Controls.Add(ayarlarUc);
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

        private void MainWin_Load(object sender, EventArgs e)
        {
            HesabimBtn.PerformClick();
            HesabimBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, HesabimBtn.Width, HesabimBtn.Height, 30, 30));
            ArkadaslarimBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,   ArkadaslarimBtn.Width, ArkadaslarimBtn.Height, 30, 30));
            GSohbetBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GSohbetBtn.Width, GSohbetBtn.Height, 30, 30));
            VSmkPMBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, VSmkPMBtn.Width, VSmkPMBtn.Height, 30, 30));
            AyarlarBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AyarlarBtn.Width, AyarlarBtn.Height, 30, 30));
            TesTBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TesTBtn.Width, TesTBtn.Height, 30, 30));
        }

        private void MainWDGW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = e.RowIndex;
            if (secilen == 0)
            {
                MyProfil myProfil = new MyProfil(firebase_Client1,KullaniciID);
                myProfil.ProfileIDTB.Text = MainWDGW.Rows[secilen].Cells[0].Value.ToString();
                myProfil.ProfilAdTB.Text = MainWDGW.Rows[secilen].Cells[1].Value.ToString();
                myProfil.ProfilSydTB.Text = MainWDGW.Rows[secilen].Cells[2].Value.ToString();
                myProfil.ProfilUlkeTB.Text = MainWDGW.Rows[secilen].Cells[3].Value.ToString();
                myProfil.ProfilNoTB.Text = MainWDGW.Rows[secilen].Cells[4].Value.ToString();
                myProfil.ShowDialog();

                Kullanicilari_Listele();
            }
        }
    }
}
