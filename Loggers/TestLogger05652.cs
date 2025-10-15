using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05652 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05652>();

    public override int Id => 5652;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05652), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05652), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05652), Id);
        }
    }
}

