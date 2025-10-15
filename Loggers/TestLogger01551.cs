using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01551 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01551>();

    public override int Id => 1551;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01551), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01551), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01551), Id);
        }
    }
}

