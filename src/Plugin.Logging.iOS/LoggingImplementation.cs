using System;
using Foundation;
using Plugin.Logging.Abstractions;

namespace Plugin.Logging
{
    /// <summary>
    /// iOS logging implementation.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoggingImplementation : ILogging
    {
        /// <inheritdoc />
        public void Write(Severity severity, string message, string sender, Exception exception)
        {
            var exStr = "";
            if (exception != null)
            {
                exStr = $": Exception: {exception.Message}";
            }
            Console.WriteLine($"{Enum.GetName(typeof(Severity), severity)}: {sender}: {message}{exStr}");
        }
    }
}
