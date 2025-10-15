using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02091 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02091>();

    public override int Id => 2091;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02091), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02091), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02091), Id);
        }
    }
}

