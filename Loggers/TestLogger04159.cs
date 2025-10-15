using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04159 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04159>();

    public override int Id => 4159;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04159), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04159), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04159), Id);
        }
    }
}

