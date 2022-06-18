//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using System;
using System.Windows.Forms;

namespace GeometricShapes3
{
    [Serializable]
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
