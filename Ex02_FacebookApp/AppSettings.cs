using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ex02_FacebookApp
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private readonly string r_filePath = "..\\..\\appSettings.xml";

        public void LoadData()
        {
            try
            {
                loadFromFile();
            }
            catch(Exception)
            {
                getDefaultValues();
            }
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(r_filePath, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        private void loadFromFile()
        {
            AppSettings obj = null;
            using (Stream stream = new FileStream(r_filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                obj = serializer.Deserialize(stream) as AppSettings;
            }
            
            if(obj != null)
            {
                this.RememberUser = obj.RememberUser;
                this.LastWindowSize = obj.LastWindowSize;
                this.LastWindowLocation = obj.LastWindowLocation;
                this.LastAccessToken = obj.LastAccessToken;
            }
        }

        private void getDefaultValues()
        {
            LastWindowLocation = new Point(50, 50);
            LastWindowSize = new Size(1000, 800);
            RememberUser = false;
            LastAccessToken = null;
        }
    }
}
