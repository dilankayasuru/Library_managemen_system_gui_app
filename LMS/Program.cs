using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LMS.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LMS
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FreeConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(new Library()));
            ////Application.Run(new LibrarianWindow());
            //Application.Run(new MemberWindow(new Member("sada", "asd", "asd", "asd", "asd")));
        }
    }
}
