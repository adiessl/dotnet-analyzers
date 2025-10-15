using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03850 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03850>();

    public override int Id => 3850;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03850), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03850), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03850), Id);
        }
    }
}

