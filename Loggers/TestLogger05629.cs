using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05629 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05629>();

    public override int Id => 5629;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05629), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05629), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05629), Id);
        }
    }
}

