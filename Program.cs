using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhos2
{
    internal static class Program
    {
        public static Timer aTimer;

        public static Lanterna lanterna;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aTimer = new Timer();
            lanterna = new Lanterna();
            lanterna.bateriaAtual = new Bateria();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
