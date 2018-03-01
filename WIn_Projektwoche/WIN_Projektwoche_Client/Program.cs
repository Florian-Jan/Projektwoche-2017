using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN_Projektwoche_Client
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new WIN_Projektwoche_Client());
=======
            Application.Run(new WIN_Projektwoche_Server());
>>>>>>> 49b513b5d543fde1ae27e273a0d39bd2d2ef5899
        }
    }
}
