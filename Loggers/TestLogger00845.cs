using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00845 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00845>();

    public override int Id => 845;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00845), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00845), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00845), Id);
        }
    }
}

