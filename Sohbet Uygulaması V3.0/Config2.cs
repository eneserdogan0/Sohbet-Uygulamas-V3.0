using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sohbet_Uygulaması_V3._0
{
    public class Config2
    {
        private string _authDomain;
        private string _apiKey;
        private string _fbrealtimeDataBase;
        private string _firebaseStorage;
        public Config2()
        {
            XmlDocument Config = new XmlDocument();
            Config.Load("Config.xml");

            string AuthDomain = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/AuthDomain").InnerText.Trim();
            string ApiKey = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/ApiKey").InnerText.Trim();
            string FBRealtimeDataBase = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/FBRealtimeDataBase").InnerText.Trim();
            string FireBaseStorage = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/FireBaseStorage").InnerText.Trim();
        }

        public string AuthDomain
        {
            get { return _authDomain; }
        }
        public string ApiKey
        {
            get { return _apiKey; }
        }
        public string FBRealtimeDataBase
        {
            get { return _fbrealtimeDataBase; }
        }
        public string FireBaseStorage
        {
            get { return _firebaseStorage; }
        }
        
    }
}
