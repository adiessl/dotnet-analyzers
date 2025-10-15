using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09677 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09677>();

    public override int Id => 9677;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09677), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09677), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09677), Id);
        }
    }
}

