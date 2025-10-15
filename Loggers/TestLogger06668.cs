using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06668 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06668>();

    public override int Id => 6668;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06668), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06668), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06668), Id);
        }
    }
}

