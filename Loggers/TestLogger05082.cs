using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05082 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05082>();

    public override int Id => 5082;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05082), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05082), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05082), Id);
        }
    }
}

