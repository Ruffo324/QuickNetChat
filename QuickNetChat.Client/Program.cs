using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNetChat.Client
{
    static class Program
    {
        public static DataRepository.DataRepository DataRepository;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open SplashScreen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            splashScreen.SetLoadingText("Initializing Database");

            Application.DoEvents();
            // Create DataRepository
            DataRepository = new DataRepository.DataRepository();

            // Close SplashScreen & Show UI
            splashScreen.Close();
            Application.Run(new Form1());
        }
    }
}
