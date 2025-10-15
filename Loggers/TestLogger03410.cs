using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03410 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03410>();

    public override int Id => 3410;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03410), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03410), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03410), Id);
        }
    }
}

