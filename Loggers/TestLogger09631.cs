using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09631 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09631>();

    public override int Id => 9631;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09631), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09631), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09631), Id);
        }
    }
}

