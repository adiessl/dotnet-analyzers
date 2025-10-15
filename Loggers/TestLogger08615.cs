using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08615 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08615>();

    public override int Id => 8615;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08615), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08615), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08615), Id);
        }
    }
}

