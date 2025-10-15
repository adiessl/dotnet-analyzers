using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09911 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09911>();

    public override int Id => 9911;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09911), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09911), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09911), Id);
        }
    }
}

