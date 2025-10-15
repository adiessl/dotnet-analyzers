using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01221 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01221>();

    public override int Id => 1221;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01221), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01221), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01221), Id);
        }
    }
}

