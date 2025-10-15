using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03599 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03599>();

    public override int Id => 3599;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03599), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03599), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03599), Id);
        }
    }
}

