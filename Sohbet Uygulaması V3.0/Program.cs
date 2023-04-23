using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sohbet_Uygulaması_V3._0
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument Config = new XmlDocument();
            Config.Load("Config.xml");

            string AuthDomain = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/AuthDomain").InnerText.Trim();
            string ApiKey = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/ApiKey").InnerText.Trim();

            MessageBox.Show("domainn",AuthDomain);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisSecenekleri(ApiKey,AuthDomain));
        }
    }
}
