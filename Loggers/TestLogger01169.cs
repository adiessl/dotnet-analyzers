using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01169 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01169>();

    public override int Id => 1169;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01169), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01169), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01169), Id);
        }
    }
}

