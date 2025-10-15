using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02531 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02531>();

    public override int Id => 2531;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02531), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02531), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02531), Id);
        }
    }
}

