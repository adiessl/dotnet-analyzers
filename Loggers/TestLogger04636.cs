using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04636 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04636>();

    public override int Id => 4636;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04636), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04636), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04636), Id);
        }
    }
}

