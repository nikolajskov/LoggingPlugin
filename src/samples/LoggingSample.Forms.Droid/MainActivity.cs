using Android.App;
using Android.OS;
using Android.Content.PM;
using LoggingSample.Forms.Shared;
using Plugin.Logging;
using System;

namespace LoggingSample.Forms.Droid
{
    [Activity(MainLauncher = true, LaunchMode = LaunchMode.SingleTask, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Logging.Init("FOO_ANDROID");
            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        protected override void OnStart()
        {
            base.OnStart();

            var tag = "FOO_ANDROID_LOCAL";

            Logging.Verbose($"{nameof(MainActivity)}.{nameof(OnStart)}");
            Logging.Verbose($"{nameof(MainActivity)}.{nameof(OnStart)}", tag);
            Logging.Debug($"{nameof(MainActivity)}.{nameof(OnStart)}");
            Logging.Debug($"{nameof(MainActivity)}.{nameof(OnStart)}", tag);
            Logging.Info($"{nameof(MainActivity)}.{nameof(OnStart)}");
            Logging.Info($"{nameof(MainActivity)}.{nameof(OnStart)}", tag);
            Logging.Warning($"{nameof(MainActivity)}.{nameof(OnStart)}");
            Logging.Warning($"{nameof(MainActivity)}.{nameof(OnStart)}", new Exception("Something bad happened"));
            Logging.Warning($"{nameof(MainActivity)}.{nameof(OnStart)}", tag);
            Logging.Warning($"{nameof(MainActivity)}.{nameof(OnStart)}", tag, new Exception("Something bad happened"));
            Logging.Error($"{nameof(MainActivity)}.{nameof(OnStart)}");
            Logging.Error($"{nameof(MainActivity)}.{nameof(OnStart)}", new Exception("Something really bad happened"));
            Logging.Error($"{nameof(MainActivity)}.{nameof(OnStart)}", tag);
            Logging.Error($"{nameof(MainActivity)}.{nameof(OnStart)}", tag, new Exception("Something really bad happened"));
        }
    }
}
