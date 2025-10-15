using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01001 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01001>();

    public override int Id => 1001;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01001), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01001), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01001), Id);
        }
    }
}

