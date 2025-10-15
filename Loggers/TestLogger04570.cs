using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04570 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04570>();

    public override int Id => 4570;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04570), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04570), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04570), Id);
        }
    }
}

