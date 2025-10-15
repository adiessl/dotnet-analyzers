using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04578 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04578>();

    public override int Id => 4578;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04578), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04578), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04578), Id);
        }
    }
}

