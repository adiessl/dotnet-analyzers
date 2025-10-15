using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05816 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05816>();

    public override int Id => 5816;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05816), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05816), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05816), Id);
        }
    }
}

