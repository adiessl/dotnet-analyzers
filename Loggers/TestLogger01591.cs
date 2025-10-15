using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01591 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01591>();

    public override int Id => 1591;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01591), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01591), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01591), Id);
        }
    }
}

