using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01544 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01544>();

    public override int Id => 1544;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01544), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01544), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01544), Id);
        }
    }
}

