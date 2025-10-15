using Common;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console(formatProvider: System.Globalization.CultureInfo.InvariantCulture)
    .CreateLogger();

Log.Information("Hello, Serilog!");

var loggers = TestLogger.GetInstances();

foreach (var logger in loggers)
{
    logger.Log();
}

Log.Information("Number of loggers: {LoggerCount}", loggers.Count);
