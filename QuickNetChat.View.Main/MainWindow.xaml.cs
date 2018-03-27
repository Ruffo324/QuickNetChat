using System.Windows;

namespace QuickNetChat.View.Main
{
    /// <inheritdoc cref="Window" />
    /// <summary>
    ///     Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SplashScreen.MainWindow _splashScreenMainWindow;
        private bool _startupCompletlyDone;

        public MainWindow()
        {
            // Setup application.
            _splashScreenMainWindow = new SplashScreen.MainWindow();
            _splashScreenMainWindow.Show();

            // Bind event of database initalization, update progress.
            DataRepository.DataContext.OnDataContextInitialized += OnOnDataContextInitialized;
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

            // LOL...
            InitializeComponent();
        }
    }
}