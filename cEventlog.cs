using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace ShaftpowerTest
{
    public class cEventlog
    {
        StreamWriter sw;
        private static string sPath = Application.StartupPath  + "\\Log\\";
        public string addStr;
        Object thisLock = new Object();
        string fileName;
        string trennZeichen = ";";

        void Open()
        {
            System.IO.Directory.CreateDirectory(sPath);
            sw = File.AppendText(fileName);
        }

        public cEventlog(string fileN, string extension)
        {
            System.DateTime zeit;
            zeit = System.DateTime.Now;
            fileName = sPath + fileN + " " + zeit.ToShortDateString() + "." + extension;
            fileName = fileName.Replace('/', '.'); // Us Datumsformat Convertierung
        }

        public void EventLog(String logMessage)
        {
            lock (thisLock)
            {
                Open();
                DateTime now = DateTime.Now;
                string msg = now.ToString("dd.MM.yyyy HH:mm:ss") + " " + logMessage;
                sw.WriteLine("{0}; " + logMessage, now.ToString ("dd.MM.yyyy HH:mm:ss,FFF"));
                sw.Flush();
                sw.Close();
                sw = null;
            }
        }

        public void EventLog(Exception ex)
        {
            EventLog(ex.Message + " StackTrace: " + ex.StackTrace);
        }

        public void Add(Object obj)
        {
            if (obj != null)
                addStr += trennZeichen + obj.ToString();
            else
                addStr += trennZeichen + "null";
        }

        public void AddFlush()
        {
             EventLog(addStr);
             addStr = "";
        }
     }
}
