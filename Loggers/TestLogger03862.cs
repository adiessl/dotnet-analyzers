using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03862 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03862>();

    public override int Id => 3862;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03862), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03862), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03862), Id);
        }
    }
}

