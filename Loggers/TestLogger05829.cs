using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05829 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05829>();

    public override int Id => 5829;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05829), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05829), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05829), Id);
        }
    }
}

