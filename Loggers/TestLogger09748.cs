using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09748 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09748>();

    public override int Id => 9748;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09748), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09748), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09748), Id);
        }
    }
}

