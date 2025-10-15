using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09965 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09965>();

    public override int Id => 9965;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09965), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09965), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09965), Id);
        }
    }
}

