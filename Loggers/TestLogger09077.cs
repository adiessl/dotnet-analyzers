using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09077 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09077>();

    public override int Id => 9077;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09077), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09077), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09077), Id);
        }
    }
}

