using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05506 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05506>();

    public override int Id => 5506;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05506), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05506), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05506), Id);
        }
    }
}

