using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03682 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03682>();

    public override int Id => 3682;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03682), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03682), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03682), Id);
        }
    }
}

