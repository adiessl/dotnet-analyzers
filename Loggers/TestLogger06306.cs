using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06306 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06306>();

    public override int Id => 6306;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06306), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06306), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06306), Id);
        }
    }
}

