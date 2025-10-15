using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05683 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05683>();

    public override int Id => 5683;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05683), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05683), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05683), Id);
        }
    }
}

