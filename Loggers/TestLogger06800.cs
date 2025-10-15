using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06800 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06800>();

    public override int Id => 6800;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06800), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06800), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06800), Id);
        }
    }
}

