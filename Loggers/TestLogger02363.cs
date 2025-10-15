using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02363 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02363>();

    public override int Id => 2363;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02363), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02363), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02363), Id);
        }
    }
}

