using System;
using System.Configuration;
using System.IO;

namespace SWP_Uebung1_Singleton
{
    sealed class LazyPrint
    {
            private static readonly Lazy<LazyPrint> singleInstance = new(() => new LazyPrint()); //private static Singleton singleInstance = null;  
           
            public static LazyPrint SingleInstance
        {
                get
                {
                    return singleInstance.Value;
                }
            }
            public void LogMessage(string message)
            {
            string path = ConfigurationManager.AppSettings.Get("FilePath");
            using FileStream fs = new FileStream(@path
                    , FileMode.OpenOrCreate
                    , FileAccess.ReadWrite);
                StreamWriter tw = new StreamWriter(fs);
                tw.WriteLine(DateTime.Now + ";" + ConfigurationManager.AppSettings.Get("Username") + ";" + message);
                tw.Flush();
            }
        
    }

}
