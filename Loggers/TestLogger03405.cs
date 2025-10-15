using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03405 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03405>();

    public override int Id => 3405;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03405), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03405), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03405), Id);
        }
    }
}

