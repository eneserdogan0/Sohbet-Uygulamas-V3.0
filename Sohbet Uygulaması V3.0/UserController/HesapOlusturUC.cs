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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V3._0.UserController
{
    public partial class HesapOlusturUC : UserControl
    {
        
        public HesapOlusturUC()
        {
            InitializeComponent();          
          
        }
               

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CreSifUCTB.PasswordChar = '\0';

            }
            else
            {
                CreSifUCTB.PasswordChar = '?';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HesapOlusturUC_Load(object sender, EventArgs e)
        {

        }

        private  void HesapOlusturulduBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
