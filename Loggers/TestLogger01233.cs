using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01233 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01233>();

    public override int Id => 1233;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01233), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01233), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01233), Id);
        }
    }
}

