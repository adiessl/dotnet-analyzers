using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01932 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01932>();

    public override int Id => 1932;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01932), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01932), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01932), Id);
        }
    }
}

