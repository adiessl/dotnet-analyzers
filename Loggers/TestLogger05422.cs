using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05422 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05422>();

    public override int Id => 5422;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05422), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05422), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05422), Id);
        }
    }
}

