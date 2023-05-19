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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sohbet_Uygulaması_V3._0.MainWinUserController
{
    public partial class ArkadaslarimUC : UserControl
    {

        //private FirebaseClient istemciArkadas;
        //private UserCredential ProfilIDArkadas;

        public ArkadaslarimUC()
        {
            InitializeComponent();
            //this.istemciArkadas = istemciArkadas;
            //this.ProfilIDArkadas = ProfilIDArkadas;
        }

        private void ArkIDTB_TextChanged(object sender, EventArgs e)
        {
            //string gmailID = ArkIDTB.Text.Trim();

            ////var deger = istemciArkadas.Child("gmailID").EqualTo(gmailID);
            ////deger.GetValueAsync().ContinueWith(task =>

            //var deger = await istemciArkadas.Child("kullanicilar").OrderBy("gmailID").EqualTo(gmailID).OnceAsync<Kullanicilarr>();
            //{
            //    //if (deger.Any())
            //    //{
            //        
            //        //var dataSnapshot = task.Result;
            //        if (deger.Any())
            //        {
            //        
            //        
            //        ArkDGW.DataSource = deger.Select(x => new { x.Key, x.Object }).ToList();
            //        }
            //        else
            //        {
            //        MessageBox.Show("GmailID bulunamadı.");
            //        }
            //    //}
            //}//);

        }
    }
}
