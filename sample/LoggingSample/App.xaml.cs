using Plugin.Logging;
using Xamarin.Forms;

namespace LoggingSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Logging.Verbose("Verbose");
            Logging.Verbose("Verbose", new System.Exception("Exception message"));
            Logging.Debug("Debug");
            Logging.Debug("Debug", new System.Exception("Exception message"));
            Logging.Info("Info");
            Logging.Info("Info", new System.Exception("Exception message"));
            Logging.Warning("Warning");
            Logging.Warning("Warning", new System.Exception("Exception message"));
            Logging.Error("Error");
            Logging.Error("Error", new System.Exception("Exception message"));
            Logging.Fatal("Fatal");
            Logging.Fatal("Fatal", new System.Exception("Exception message"));
        }
    }
}
