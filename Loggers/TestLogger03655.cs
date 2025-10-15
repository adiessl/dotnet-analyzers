using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03655 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03655>();

    public override int Id => 3655;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03655), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03655), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03655), Id);
        }
    }
}

