using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01200 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01200>();

    public override int Id => 1200;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01200), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01200), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01200), Id);
        }
    }
}

