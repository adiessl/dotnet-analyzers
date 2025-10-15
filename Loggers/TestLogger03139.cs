using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03139 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03139>();

    public override int Id => 3139;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03139), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03139), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03139), Id);
        }
    }
}

