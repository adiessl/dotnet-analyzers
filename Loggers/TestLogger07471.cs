using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07471 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07471>();

    public override int Id => 7471;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07471), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07471), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07471), Id);
        }
    }
}

