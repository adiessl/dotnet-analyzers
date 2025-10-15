using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00200 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00200>();

    public override int Id => 200;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00200), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00200), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00200), Id);
        }
    }
}

