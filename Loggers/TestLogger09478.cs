using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09478 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09478>();

    public override int Id => 9478;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09478), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09478), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09478), Id);
        }
    }
}

