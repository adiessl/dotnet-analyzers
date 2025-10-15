using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05368 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05368>();

    public override int Id => 5368;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05368), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05368), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05368), Id);
        }
    }
}

