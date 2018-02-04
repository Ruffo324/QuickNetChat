using System;
using System.Windows.Forms;
using QuickNetChat.Server;

namespace QuickNetChat.Client
{
    static class Program
    {
        public static DataRepository.DataRepository DataRepository;
        public static Server.TcpHandler TcpHandler;

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
            TcpHandler = new TcpHandler();

            // Close SplashScreen & Show UI
            splashScreen.Close();
            Application.Run(new Main());
        }
    }
}
