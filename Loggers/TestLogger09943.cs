using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09943 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09943>();

    public override int Id => 9943;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09943), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09943), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09943), Id);
        }
    }
}

