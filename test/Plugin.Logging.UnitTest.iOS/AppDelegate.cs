using Foundation;
using MonoTouch.NUnit.UI;
using UIKit;

namespace Plugin.Logging.UnitTest.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        private UIWindow _window;
        private TouchRunner _runner;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);
            _runner = new TouchRunner(_window);

            _runner.Add(System.Reflection.Assembly.GetExecutingAssembly());

            _window.RootViewController = new UINavigationController(_runner.GetViewController());

            _window.MakeKeyAndVisible();

            return true;
        }
    }
}
