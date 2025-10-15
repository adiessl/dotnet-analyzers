using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01028 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01028>();

    public override int Id => 1028;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01028), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01028), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01028), Id);
        }
    }
}

