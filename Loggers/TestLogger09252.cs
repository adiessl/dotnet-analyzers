using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09252 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09252>();

    public override int Id => 9252;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09252), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09252), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09252), Id);
        }
    }
}

