using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03619 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03619>();

    public override int Id => 3619;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03619), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03619), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03619), Id);
        }
    }
}

