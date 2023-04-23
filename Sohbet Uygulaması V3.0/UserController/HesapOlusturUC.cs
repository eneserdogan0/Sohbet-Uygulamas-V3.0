using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                SifreTB.PasswordChar = '\0';

            }
            else
            {
                SifreTB.PasswordChar = '?';
            }
        }
    }
}
