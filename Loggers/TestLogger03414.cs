using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03414 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03414>();

    public override int Id => 3414;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03414), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03414), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03414), Id);
        }
    }
}

