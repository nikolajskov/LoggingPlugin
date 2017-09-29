namespace Plugin.Logging.Abstractions
{
    public interface ILogging
    {
        /// <summary>
        /// Write a log message to the native platform logging framework.
        /// </summary>
        /// <param name="severity">The severity of the message.</param>
        /// <param name="message">The message to write.</param>
        /// <param name="sender">The sender of the message.</param>
        /// <param name="exception">The exception causing the issue.</param>
        void Write(Severity severity, string message, string sender, System.Exception exception);
    }
}
