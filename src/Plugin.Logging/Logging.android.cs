using Android.Util;
using System;

namespace Plugin.Logging
{
    public static partial class Logging
    {
        private static string Tag { get; set; } = "";

        private static Severity Severity { get; set; } = Severity.All;

        public static void Init(string tag, Severity severity = Severity.All)
        {
            Tag = tag;
            Severity = severity;
        }

        private static void PlatformVerbose(string message) => PlatformVerbose(message, Tag);

        private static void PlatformVerbose(string message, string tag)
        {
            if ((Severity & Severity.Verbose) == Severity.Verbose)
            {
                Log.Verbose(tag, message);
            }
        }

        private static void PlatformDebug(string message) => PlatformDebug(message, Tag);

        private static void PlatformDebug(string message, string tag)
        {
            if ((Severity & Severity.Debug) == Severity.Debug)
            {
                Log.Debug(tag, message);
            }
        }

        private static void PlatformInfo(string message) => PlatformInfo(message, Tag);

        private static void PlatformInfo(string message, string tag)
        {
            if ((Severity & Severity.Info) == Severity.Info)
            {
                Log.Info(tag, message);
            }
        }

        private static void PlatformWarning(string message, Exception exception = null) => PlatformWarning(message, Tag, exception);

        private static void PlatformWarning(string message, string tag, Exception exception = null)
        {
            if ((Severity & Severity.Warning) == Severity.Warning)
            {
                if (exception != null)
                {
                    Log.Warn(tag, Java.Lang.Throwable.FromException(exception), message);
                }
                else
                {
                    Log.Warn(tag, message);
                }
            }
        }

        private static void PlatformError(string message, Exception exception = null) => PlatformError(message, Tag, exception);

        private static void PlatformError(string message, string tag, Exception exception = null)
        {
            if ((Severity & Severity.Error) == Severity.Error)
            {
                if (exception != null)
                {
                    Log.Error(tag, Java.Lang.Throwable.FromException(exception), message);
                }
                else
                {
                    Log.Error(tag, message);
                }
            }
        }
    }
}
