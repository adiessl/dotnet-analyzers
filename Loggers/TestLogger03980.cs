using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03980 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03980>();

    public override int Id => 3980;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03980), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03980), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03980), Id);
        }
    }
}

