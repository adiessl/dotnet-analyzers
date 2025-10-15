using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02449 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02449>();

    public override int Id => 2449;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02449), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02449), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02449), Id);
        }
    }
}

