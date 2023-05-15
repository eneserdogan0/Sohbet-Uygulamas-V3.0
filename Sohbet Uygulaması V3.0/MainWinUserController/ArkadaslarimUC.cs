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

            ////var query = istemciArkadas.Child("gmailID").EqualTo(gmailID);
            ////query.GetValueAsync().ContinueWith(task =>

            //var query = await istemciArkadas.Child("kullanicilar").OrderBy("gmailID").EqualTo(gmailID).OnceAsync<Kullanicilarr>();
            //{
            //    //if (query.Any())
            //    //{
            //        // Sorgu sonucunda elde edilen verileri DataGridView'e aktarın.
            //        //var dataSnapshot = task.Result;
            //        if (query.Any())
            //        {
            //        // Veritabanından alınan verileri işleyin ve DataGridView'e aktarın.
            //        // Bu adımda DataGridView.DataSource veya Rows.Add metotlarını kullanabilirsiniz.
            //        ArkDGW.DataSource = query.Select(x => new { x.Key, x.Object }).ToList();
            //        }
            //        else
            //        {
            //        // Belirtilen Gmail ID'sine ait veri bulunamadı.
            //        MessageBox.Show("Belirtilen Gmail ID'sine ait veri bulunamadı.");
            //        }
            //    //}
            //    //else if (task.IsFaulted)
            //    //{
            //    //    // Hata oluştu, Firebase sorgusu başarısız oldu.
            //    //}
            //}//);

        }
    }
}
