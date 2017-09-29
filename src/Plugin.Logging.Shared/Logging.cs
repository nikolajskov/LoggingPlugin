using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Plugin.Logging.Abstractions;

namespace Plugin.Logging
{
    /// <summary>
    /// Cross platform logging.
    /// </summary>
    public static class Logging
    {
        private static readonly Lazy<ILogging> Implementation = new Lazy<ILogging>(CreateImplementation, LazyThreadSafetyMode.PublicationOnly);

        private static ILogging Current
        {
            get
            {
                var current = Implementation.Value;
                if (current == null)
                {
                    throw new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
                }
                return current;
            }
        }

        private static ILogging CreateImplementation()
        {
#if NETSTANDARD1_0
            return null;
#else
            return new LoggingImplementation();
#endif
        }

        /// <summary>
        /// Write a verbose log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Verbose(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Verbose, message, sender, null);
        }

        /// <summary>
        /// Write a verbose log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Verbose(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Verbose, message, sender, exception);
        }

        /// <summary>
        /// Write a debug log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Debug(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Debug, message, sender, null);
        }

        /// <summary>
        /// Write a debug log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Debug(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Debug, message, sender, exception);
        }

        /// <summary>
        /// Write an info log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Info(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Information, message, sender, null);
        }

        /// <summary>
        /// Write an info log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Info(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Information, message, sender, exception);
        }

        /// <summary>
        /// Write a warning log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Warning(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Warning, message, sender, null);
        }

        /// <summary>
        /// Write a warning log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Warning(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Warning, message, sender, exception);
        }

        /// <summary>
        /// Write an error log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Error(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Error, message, sender, null);
        }

        /// <summary>
        /// Write an error log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Error(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Error, message, sender, exception);
        }

        /// <summary>
        /// Write a fatal log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Fatal(string message, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Fatal, message, sender, null);
        }

        /// <summary>
        /// Write a fatal log message to the native logging framework.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="exception">The exception causing the issue.</param>
        /// <param name="sender">The sender of the message. If omitted the name of the calling method will be used.</param>
        public static void Fatal(string message, Exception exception, [CallerMemberName] string sender = "")
        {
            Current.Write(Severity.Fatal, message, sender, exception);
        }
    }
}
