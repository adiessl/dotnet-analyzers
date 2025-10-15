using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00988 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00988>();

    public override int Id => 988;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00988), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00988), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00988), Id);
        }
    }
}

