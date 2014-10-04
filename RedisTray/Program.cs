using RedisTray.Properties;
using System;
using System.Windows.Forms;

namespace RedisTray
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var f = new FrmMain();

            if (!Settings.Default.StartHidden)
            {
                f.Show();
            }
            else
            {
                f.AutoStartIfConfigured();
            }

            Application.Run();
        }
    }
}
