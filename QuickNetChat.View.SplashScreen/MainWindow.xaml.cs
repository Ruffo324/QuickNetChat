using System.Windows;
using QuickNetChat.View.SplashScreen.Exceptions;

namespace QuickNetChat.View.SplashScreen
{
    /// <inheritdoc cref="Window" />
    /// <summary>
    ///     Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _lastUpdateProgress;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateProgress(string message, string submessage)
        {
            // Set last message, apply message to loading bar.
            _lastUpdateProgress = message;
            LabelProgressMessage.Content = $"{message} - {submessage}";
            //TODO: Run async
        }

        public void UpdateProgress(string submessage)
        {
            // No last update progress message setten -> exception;
            if (_lastUpdateProgress == null)
                throw new SplashScreenProgressException(
                    "The function 'UpdateProgress(message, submessage)' " +
                    "must called first once before UpdateProgress(submessage).");

            // Call update progress with last main message.
            UpdateProgress(_lastUpdateProgress, submessage);
        }
    }
}