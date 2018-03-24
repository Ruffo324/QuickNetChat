using System;
using System.Windows.Forms;
using QuickNetChat.Server;
using QuickNetChat.View.SplashScreen;

namespace QuickNetChat.Client
{
    internal static class Program
    {
        public static DataRepository.DataRepository DataRepository;
        public static TcpHandler TcpHandler;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Startup process in new task
            MainWindow splashScreen = new MainWindow();
            splashScreen.Show();

            // Create DataRepository
            splashScreen.UpdateProgress("Data repository", "initializing.");
            DataRepository = new DataRepository.DataRepository();
            splashScreen.UpdateProgress("done.");

            // Create TcpHandler
            splashScreen.UpdateProgress("Tcp handler", "initializing.");
            TcpHandler = new TcpHandler();
            splashScreen.UpdateProgress("done.");

            // Close SplashScreen & Show UI
            splashScreen.Close();
            Application.Run(new Main());
        }
    }
}