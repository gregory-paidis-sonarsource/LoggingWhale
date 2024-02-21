
using NLog.Config;
using NLog.Targets;
using NLog;

namespace Logging
{
    internal class NLogExample
    {
        public static void Logging()
        {
            var foo = "foo";
            var bar = "bar";

            // Configure NLog to log to the console
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget("consoleTarget");
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, consoleTarget);
            LogManager.Configuration = config;

            // Create a logger instance
            var logger = LogManager.GetCurrentClassLogger();

            // Check name of method from a whitelist
            // Check if the first argument is called message
            // Check if the method.ContainingType is the Logger class
            // Check if the first argument is a string
            // Grab it like a madman and parse it with the regex
            logger.Info("Hey {foo} and {bar}", foo, bar);
            logger.Debug("Hey {foo} and {bar}", foo, bar);
            logger.Trace("Hey {foo} and {bar}", foo, bar);
            logger.Error("Hey {foo} and {bar}", foo, bar);
            logger.Fatal("Hey {foo} and {bar}", foo, bar);
            logger.Warn("Hey {foo} and {bar}", foo, bar);
            logger.ConditionalTrace("Hey {foo} and {bar}", foo, bar);
            logger.ConditionalDebug("Hey {foo} and {bar}", foo, bar);
        }
    }
}
