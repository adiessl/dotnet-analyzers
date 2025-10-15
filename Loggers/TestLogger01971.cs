using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01971 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01971>();

    public override int Id => 1971;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01971), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01971), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01971), Id);
        }
    }
}

