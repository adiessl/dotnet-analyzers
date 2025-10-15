using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04110 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04110>();

    public override int Id => 4110;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04110), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04110), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04110), Id);
        }
    }
}

