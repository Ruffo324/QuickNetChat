using System.Windows;
using QuickNetChat.DataRepository;

namespace QuickNetChat.View.Main
{
    /// <inheritdoc />
    /// <summary>
    ///     Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private readonly SplashScreen.MainWindow _splashScreenMainWindow;
        private bool _startupCompletlyDone;

        public App()
        {
            // Setup application.
            _splashScreenMainWindow = new SplashScreen.MainWindow();
            _splashScreenMainWindow.Show();

            // Bind event of database initalization, update progress.
            DataContext.OnDataContextInitialized += OnOnDataContextInitialized;
            _splashScreenMainWindow.UpdateProgress("Initalize Database", "Init context.");

            // Initalize data context.
            DataRepository.DataRepository dataRepository = new DataRepository.DataRepository();
            dataRepository.GetContext();
            StartupCompleteDone();
        }

        private void OnOnDataContextInitialized()
        {
            _splashScreenMainWindow.UpdateProgress("Initalize Database", "Init context.");
            _startupCompletlyDone = true;
            StartupCompleteDone();
        }

        private void StartupCompleteDone()
        {
            // TODO: Find better solution.
            if (!_startupCompletlyDone)
                return;

            // Close splash screen 
            _splashScreenMainWindow.UpdateProgress("Startup done", "done.");
            _splashScreenMainWindow.Close();
        }
    }
}