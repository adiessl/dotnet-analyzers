using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06696 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06696>();

    public override int Id => 6696;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06696), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06696), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06696), Id);
        }
    }
}

