using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02272 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02272>();

    public override int Id => 2272;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02272), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02272), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02272), Id);
        }
    }
}

