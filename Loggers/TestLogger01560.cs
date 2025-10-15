using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01560 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01560>();

    public override int Id => 1560;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01560), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01560), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01560), Id);
        }
    }
}

