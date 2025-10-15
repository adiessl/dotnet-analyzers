using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03207 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03207>();

    public override int Id => 3207;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03207), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03207), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03207), Id);
        }
    }
}

