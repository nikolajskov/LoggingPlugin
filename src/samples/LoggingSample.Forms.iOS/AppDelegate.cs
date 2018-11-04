using Foundation;
using LoggingSample.Forms.Shared;
using Plugin.Logging;
using System;
using UIKit;

namespace Blank
{
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var tag = "FOO_IOS_LOCAL";

            Logging.Init("FOO_IOS");

            Logging.Verbose($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}");
            Logging.Verbose($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag);
            Logging.Debug($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}");
            Logging.Debug($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag);
            Logging.Info($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}");
            Logging.Info($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag);
            Logging.Warning($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}");
            Logging.Warning($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", new Exception("Something bad happened"));
            Logging.Warning($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag);
            Logging.Warning($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag, new Exception("Something bad happened"));
            Logging.Error($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}");
            Logging.Error($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", new Exception("Something really bad happened"));
            Logging.Error($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag);
            Logging.Error($"{nameof(AppDelegate)}.{nameof(FinishedLaunching)}", tag, new Exception("Something really bad happened"));

            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}


