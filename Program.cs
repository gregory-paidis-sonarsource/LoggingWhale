using Serilog;
using Microsoft.Extensions.Logging;
using NLog;
using Logging;


Console.WriteLine("Microsoft.Extensions.Logging");
Console.WriteLine("============================");
MicrosoftExample.Logging();

await Task.Delay(200);

Console.WriteLine();
Console.WriteLine("Serilog");
Console.WriteLine("=======");
SerilogExample.Logging();

await Task.Delay(200);

Console.WriteLine();
Console.WriteLine("NLog");
Console.WriteLine("====");
NLogExample.Logging();

