using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06255 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06255>();

    public override int Id => 6255;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06255), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06255), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06255), Id);
        }
    }
}

