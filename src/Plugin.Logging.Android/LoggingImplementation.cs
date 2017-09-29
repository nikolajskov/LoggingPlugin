using System;
using Android.Runtime;
using Android.Util;
using Java.Lang;
using Plugin.Logging.Abstractions;

namespace Plugin.Logging
{
    /// <summary>
    /// Android logging implementation.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoggingImplementation : ILogging
    {
        /// <inheritdoc />
        public void Write(Severity severity, string message, string sender, System.Exception exception)
        {
            switch (severity)
            {
                case Severity.Verbose:
                    if (exception != null)
                    {
                        Log.Verbose(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Verbose(sender, message);
                    }
                    break;
                case Severity.Debug:
                    if (exception != null)
                    {
                        Log.Debug(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Debug(sender, message);
                    }
                    break;
                case Severity.Information:
                    if (exception != null)
                    {
                        Log.Info(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Info(sender, message);
                    }
                    break;
                case Severity.Warning:
                    if (exception != null)
                    {
                        Log.Warn(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Warn(sender, message);
                    }
                    break;
                case Severity.Error:
                    if (exception != null)
                    {
                        Log.Error(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Error(sender, message);
                    }
                    break;
                case Severity.Fatal:
                    if (exception != null)
                    {
                        Log.Wtf(sender, Throwable.FromException(exception), message);
                    }
                    else
                    {
                        Log.Wtf(sender, message);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(severity), severity, null);
            }
        }
    }
}
