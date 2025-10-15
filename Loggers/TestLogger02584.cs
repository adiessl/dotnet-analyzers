using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02584 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02584>();

    public override int Id => 2584;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02584), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02584), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02584), Id);
        }
    }
}

