using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00279 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00279>();

    public override int Id => 279;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00279), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00279), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00279), Id);
        }
    }
}

