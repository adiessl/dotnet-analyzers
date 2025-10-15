using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09574 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09574>();

    public override int Id => 9574;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09574), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09574), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09574), Id);
        }
    }
}

