using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04413 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04413>();

    public override int Id => 4413;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04413), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04413), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04413), Id);
        }
    }
}

