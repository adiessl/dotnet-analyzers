using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06909 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06909>();

    public override int Id => 6909;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06909), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06909), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06909), Id);
        }
    }
}

