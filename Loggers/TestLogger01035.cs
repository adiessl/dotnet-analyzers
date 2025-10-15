using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01035 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01035>();

    public override int Id => 1035;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01035), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01035), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01035), Id);
        }
    }
}

