using System;
using System.Configuration;
using System.IO;

namespace SWP_Uebung1_Singleton
{
    // Static implementation
    public sealed class Print
    {
        private static object syncLock = new object();

        private static Print instance = null;
        public static Print Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new Print();
                    }

                    return instance;
                }
            }

        }
      
        public void Log(string message)
        {
            string path = ConfigurationManager.AppSettings.Get("FilePath");
            using (FileStream fs = new FileStream(@path
                , FileMode.OpenOrCreate
                , FileAccess.ReadWrite))
            {
                StreamWriter tw = new StreamWriter(fs);
                tw.WriteLine(DateTime.Now + ";" + ConfigurationManager.AppSettings.Get("Username") + ";" + message);
                tw.Flush();
            }
           
            
        }
    }
}
