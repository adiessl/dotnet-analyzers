using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02370 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02370>();

    public override int Id => 2370;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02370), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02370), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02370), Id);
        }
    }
}

