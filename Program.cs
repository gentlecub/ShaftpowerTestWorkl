using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaftpowerTest
{
    static class Program
    {
        static public cEventlog eventlog;
        static Form1 formMain;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            eventlog = new cEventlog("ShaftpowerTestEventlog", "txt");
            Program.eventlog.EventLog("ShaftpowerTest start");
            formMain = new Form1();
            Application.Run(formMain);
        }
    }
}
