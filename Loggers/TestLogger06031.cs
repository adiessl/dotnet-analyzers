using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06031 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06031>();

    public override int Id => 6031;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06031), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06031), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06031), Id);
        }
    }
}

