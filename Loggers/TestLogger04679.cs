using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04679 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04679>();

    public override int Id => 4679;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04679), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04679), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04679), Id);
        }
    }
}

