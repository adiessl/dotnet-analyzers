using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01609 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01609>();

    public override int Id => 1609;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01609), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01609), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01609), Id);
        }
    }
}

