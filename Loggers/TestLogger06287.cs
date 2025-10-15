using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06287 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06287>();

    public override int Id => 6287;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06287), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06287), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06287), Id);
        }
    }
}

