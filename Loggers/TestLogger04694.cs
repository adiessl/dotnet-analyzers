using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04694 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04694>();

    public override int Id => 4694;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04694), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04694), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04694), Id);
        }
    }
}

