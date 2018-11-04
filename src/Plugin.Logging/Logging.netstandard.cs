using System;

namespace Plugin.Logging
{
    public static partial class Logging
    {
        private static void PlatformVerbose(string message) => throw new NotImplementedException(nameof(PlatformVerbose));
        private static void PlatformVerbose(string message, string tag) => throw new NotImplementedException(nameof(PlatformVerbose));

        private static void PlatformDebug(string message) => throw new NotImplementedException(nameof(PlatformDebug));
        private static void PlatformDebug(string message, string tag) => throw new NotImplementedException(nameof(PlatformDebug));

        private static void PlatformInfo(string message) => throw new NotImplementedException(nameof(PlatformInfo));
        private static void PlatformInfo(string message, string tag) => throw new NotImplementedException(nameof(PlatformInfo));

        private static void PlatformWarning(string message, Exception exception = null) => throw new NotImplementedException(nameof(PlatformWarning));
        private static void PlatformWarning(string message, string tag, Exception exception = null) => throw new NotImplementedException(nameof(PlatformWarning));

        private static void PlatformError(string message, Exception exception = null) => throw new NotImplementedException(nameof(PlatformError));
        private static void PlatformError(string message, string tag, Exception exception = null) => throw new NotImplementedException(nameof(PlatformError));
    }
}
