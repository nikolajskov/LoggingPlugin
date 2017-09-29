using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Logging;

namespace LoggingSample.Droid
{
    [Activity(Label = "LoggingSample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
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

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}
