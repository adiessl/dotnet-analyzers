using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03220 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03220>();

    public override int Id => 3220;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03220), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03220), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03220), Id);
        }
    }
}

