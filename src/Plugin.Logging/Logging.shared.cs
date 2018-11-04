using System;

namespace Plugin.Logging
{
    public static partial class Logging
    {
        public static void Verbose(string message) => PlatformVerbose(message);
        public static void Verbose(string message, string tag) => PlatformVerbose(message, tag);

        public static void Debug(string message) => PlatformDebug(message);
        public static void Debug(string message, string tag) => PlatformDebug(message, tag);

        public static void Info(string message) => PlatformInfo(message);
        public static void Info(string message, string tag) => PlatformInfo(message, tag);

        public static void Warning(string message, Exception exception = null) => PlatformWarning(message, exception);
        public static void Warning(string message, string tag, Exception exception = null) => PlatformWarning(message, tag, exception);

        public static void Error(string message, Exception exception = null) => PlatformError(message, exception);
        public static void Error(string message, string tag, Exception exception = null) => PlatformError(message, tag, exception);
    }
}
