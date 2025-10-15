using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09249 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09249>();

    public override int Id => 9249;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09249), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09249), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09249), Id);
        }
    }
}

