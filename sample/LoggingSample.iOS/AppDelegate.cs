using Foundation;
using Plugin.Logging;
using UIKit;

namespace LoggingSample.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
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

            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
