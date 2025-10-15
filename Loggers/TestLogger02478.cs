using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02478 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02478>();

    public override int Id => 2478;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02478), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02478), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02478), Id);
        }
    }
}

