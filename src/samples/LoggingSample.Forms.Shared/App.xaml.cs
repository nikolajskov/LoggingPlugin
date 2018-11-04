using Plugin.Logging;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace LoggingSample.Forms.Shared
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Logging Plugin Sample app",
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                }
            };
        }

        protected override void OnStart()
        {
            var tag = "FOO_FORMS";

            Logging.Verbose($"{nameof(App)}.{nameof(OnStart)}");
            Logging.Verbose($"{nameof(App)}.{nameof(OnStart)}", tag);
            Logging.Debug($"{nameof(App)}.{nameof(OnStart)}");
            Logging.Debug($"{nameof(App)}.{nameof(OnStart)}", tag);
            Logging.Info($"{nameof(App)}.{nameof(OnStart)}");
            Logging.Info($"{nameof(App)}.{nameof(OnStart)}", tag);
            Logging.Warning($"{nameof(App)}.{nameof(OnStart)}");
            Logging.Warning($"{nameof(App)}.{nameof(OnStart)}", new Exception("Something bad happened"));
            Logging.Warning($"{nameof(App)}.{nameof(OnStart)}", tag);
            Logging.Warning($"{nameof(App)}.{nameof(OnStart)}", tag, new Exception("Something bad happened"));
            Logging.Error($"{nameof(App)}.{nameof(OnStart)}");
            Logging.Error($"{nameof(App)}.{nameof(OnStart)}", new Exception("Something really bad happened"));
            Logging.Error($"{nameof(App)}.{nameof(OnStart)}", tag);
            Logging.Error($"{nameof(App)}.{nameof(OnStart)}", tag, new Exception("Something really bad happened"));
        }
    }
}
