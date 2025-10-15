using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08576 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08576>();

    public override int Id => 8576;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08576), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08576), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08576), Id);
        }
    }
}

