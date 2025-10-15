using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08261 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08261>();

    public override int Id => 8261;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08261), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08261), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08261), Id);
        }
    }
}

