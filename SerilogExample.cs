using Serilog;
using Serilog.Events;

namespace Logging
{
    internal class SerilogExample
    {
        public static void Logging()
        {
            var foo = "foo";
            var bar = "bar";

            // Configure Serilog to log to the console
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            // Check name of method from a whitelist
            // Check if the first argument is called messageTemplate
            // Check if the method.ContainingType is the static Log class
            // Check if the first argument is a string
            // Grab it like a madman and parse it with the regex
            Log.Verbose("Hey {foo} and {bar}", foo, bar);
            Log.Debug("Hey {foo} and {bar}", foo, bar);
            Log.Information("Hey {foo} and {bar}", foo, bar);
            Log.Warning("Hey {foo} and {bar}", foo, bar);
            Log.Error("Hey {foo} and {bar}", foo, bar);
            Log.Fatal("Hey {foo} and {bar}", foo, bar);

            // It's a good practice to flush and dispose the logger
            Log.CloseAndFlush();
        }
    }
}
