using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;

namespace Logging
{
    internal class MicrosoftExample
    {
        public static void Logging()
        {
            var foo = "foo";
            var bar = "bar";

            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = loggerFactory.CreateLogger<MicrosoftExample>();

            // Check name of method from a whitelist
            // Check if the second argument is called message
            // Check if the method.ContainingType is the LoggerExtensions class
            // Check if the second argument is a string
            // Grab it like a madman and parse it with the regex
            logger.LogInformation("Hey {foo} and {bar}", foo, bar);
            logger.LogDebug("Hey {foo} and {bar}", foo, bar);
            logger.LogTrace("Hey {foo} and {bar}", foo, bar);
            logger.LogCritical("Hey {foo} and {bar}", foo, bar);
            logger.LogWarning("Hey {foo} and {bar}", foo, bar);
            logger.LogError("Hey {foo} and {bar}", foo, bar);
            // here it's the third argument, edge case
            logger.Log(LogLevel.None, "Hey {foo} and {bar}", foo, bar);
        }
    }
}
