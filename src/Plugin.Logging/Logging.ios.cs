using Foundation;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
                Write(message, tag);
            }
        }

        private static void PlatformDebug(string message) => PlatformDebug(message, Tag);

        private static void PlatformDebug(string message, string tag)
        {
            if ((Severity & Severity.Debug) == Severity.Debug)
            {
                Write(message, tag);
            }
        }

        private static void PlatformInfo(string message) => PlatformInfo(message, Tag);

        private static void PlatformInfo(string message, string tag)
        {
            if ((Severity & Severity.Info) == Severity.Info)
            {
                Write(message, tag);
            }
        }

        private static void PlatformWarning(string message, Exception exception = null) => PlatformWarning(message, Tag, exception);

        private static void PlatformWarning(string message, string tag, Exception exception = null)
        {
            if ((Severity & Severity.Warning) == Severity.Warning)
            {
                Write(message, tag, exception);
            }
        }

        private static void PlatformError(string message, Exception exception = null) => PlatformError(message, Tag, exception);

        private static void PlatformError(string message, string tag, Exception exception = null)
        {
            if ((Severity & Severity.Error) == Severity.Error)
            {
                Write(message, tag, exception);
            }
        }

        private static void Write(string message, string tag, Exception exception = null, [CallerMemberName] string severity = "")
        {
            tag = string.IsNullOrWhiteSpace(tag) ? "" : $"{tag}: ";
            severity = severity.Substring("Platform".Length);
            var str = $"{tag}{severity}: {message}";
            if (exception != null)
            {
                str = $"{str}\n{exception.Message}";
            }
            using (var nsstr = new NSString(str))
            {
                NSLog(nsstr.Handle);
            }
        }

        [DllImport(ObjCRuntime.Constants.FoundationLibrary)]
        private extern static void NSLog(IntPtr message);
    }
}
