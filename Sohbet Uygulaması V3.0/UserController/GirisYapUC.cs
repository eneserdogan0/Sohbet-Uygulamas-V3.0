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

namespace Sohbet_Uygulaması_V3._0.UserController
{
    public partial class GirisYapUC : UserControl
    {
        List<Image> images = new List<Image>();
        string[] DataYeri = new string[25];

        public GirisYapUC()
        {
            InitializeComponent();

            DataYeri[0] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\0 - TıklanmısHali.png";
            DataYeri[1] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\1-HARF.png";
            DataYeri[2] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\2-HARD.png";
            DataYeri[3] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\3-HARF.png";
            DataYeri[4] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\4-HARF.png";
            DataYeri[5] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\5-HARF.png";
            DataYeri[6] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\6-HARF.png";
            DataYeri[7] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\7-HARF.png";
            DataYeri[8] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\8-HARF.png";
            DataYeri[9] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\9-HARF.png";
            DataYeri[10] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\10-HARF.png";
            DataYeri[11] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\11-HARF.png";
            DataYeri[12] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\12-HARF.png";
            DataYeri[13] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\13-HARF.png";
            DataYeri[14] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\14-HARF.png";
            DataYeri[15] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\15-HARF.png";
            DataYeri[16] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\16-HARF.png";
            DataYeri[17] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\17-HARF.png";
            DataYeri[18] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\18-HARF.png";
            DataYeri[19] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\19-HARF.png";
            DataYeri[20] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\20-HARF.png";
            DataYeri[21] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\21-HARF.png";
            DataYeri[22] = @"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\22_HARF.png";
            DataYeri[23] = @"C:\Users\ASUS TUF GAMİNG\Downloads\BeyazPostluAyıdefault.PNG";

            OynatAnimasyonu();
        }


        private void OynatAnimasyonu()
        {
            for (int i = 0; i < 23; i++)
            {
                if (File.Exists(DataYeri[i])) // Dosya var mı kontrolü
                {
                    try
                    {
                        Bitmap bitmap = new Bitmap(DataYeri[i]);
                        images.Add(bitmap);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);              // Hatanın nedenini belirlemek için hata mesajını yazdırabilirsiniz.
                    }
                }
                else
                {
                    Console.WriteLine("Dosya bulunamadı: " + DataYeri[i]);      // Dosya bulunamadıysa hata mesajı yazdırabilirsiniz.
                }
            }
            images.Add(Properties.Resources._22_HARF);
        }

        private void GosterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (GosterCB.Checked)
            {
                LogSifUCTB.PasswordChar = '\0';
                Bitmap bmpass2 = new Bitmap(@"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\SifreAcik.png");
                pictureBox1.Image = bmpass2;
            }
            else
            {
                LogSifUCTB.PasswordChar = '*';
            }
        }

        private void GirisYapUC_Load(object sender, EventArgs e)
        {

        }

        private void LogKaUCTB_TextChanged(object sender, EventArgs e)
        {
            if (LogKaUCTB.Text.Length > 0 && LogKaUCTB.Text.Length <= 20)
            {
                pictureBox1.Image = images[LogKaUCTB.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (LogKaUCTB.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.BeyazPostluAyıdefault;
            else
                pictureBox1.Image = images[22];
        }

        private void LogSifUCTB_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"C:\Users\ASUS TUF GAMİNG\Desktop\GörselProgramlamaAnimasyonYeti\SifreKapali.png");
            pictureBox1.Image = bmpass;
        }

        private void LogKaUCTB_Click(object sender, EventArgs e)
        {
            if (LogKaUCTB.Text.Length > 0)
                pictureBox1.Image = images[LogKaUCTB.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.BeyazPostluAyıdefault;
        }
    }
}
