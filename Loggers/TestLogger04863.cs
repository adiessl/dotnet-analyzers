using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04863 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04863>();

    public override int Id => 4863;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04863), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04863), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04863), Id);
        }
    }
}

