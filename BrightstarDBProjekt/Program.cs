using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrightstarDBProjekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyEntityContext context = new MyEntityContext("Type=embedded;StoresDirectory=c:\\brightstardb;StoreName=korisnici");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Prijava(context));
        }
    }
}
