using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01329 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01329>();

    public override int Id => 1329;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01329), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01329), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01329), Id);
        }
    }
}

