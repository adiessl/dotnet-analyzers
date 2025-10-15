using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09118 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09118>();

    public override int Id => 9118;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09118), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09118), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09118), Id);
        }
    }
}

