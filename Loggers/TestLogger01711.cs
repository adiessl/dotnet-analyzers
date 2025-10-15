using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01711 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01711>();

    public override int Id => 1711;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01711), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01711), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01711), Id);
        }
    }
}

