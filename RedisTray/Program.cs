using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedisTray.Properties;

namespace RedisTray
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var f = new FrmMain();

            if (!Settings.Default.StartHidden)
            {
                f.Show();
            }

            Application.Run();
        }
    }
}
