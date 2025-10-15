using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01661 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01661>();

    public override int Id => 1661;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01661), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01661), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01661), Id);
        }
    }
}

