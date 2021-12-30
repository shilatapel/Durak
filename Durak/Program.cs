using System;
using System.Windows.Forms;

namespace Durak
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        
        //start program from welcome screen
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
            //Application.Run(new Menu());
        }
    }
}