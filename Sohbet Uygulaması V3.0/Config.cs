using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sohbet_Uygulaması_V3._0
{
    public  class Config
    {
        private string _authdomain;
        private string _apikey;
        private string _fbrealtimedatabase;
        private string _firebasestorage;
        public Config() 
        {

            XmlDocument Config = new XmlDocument();
            Config.Load("Config.xml");

            _authdomain = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/AuthDomain").InnerText.Trim();
            _apikey = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/ApiKey").InnerText.Trim();
            _fbrealtimedatabase = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/FBRealtimeDataBase").InnerText.Trim();
            _firebasestorage = Config.DocumentElement.SelectSingleNode("/FireBaseAuth/FireBaseStorage").InnerText.Trim();
        }

        public string AuthDomain
        {
            get { return _authdomain; }
        }
        public string ApiKey
        {
            get { return _apikey; }
        }
        public string FBRealtimeDataBase
        {
            get { return _fbrealtimedatabase; }
        }
        public string FireBaseStorage
        {
            get { return _firebasestorage; }
        }
    
    }
}
