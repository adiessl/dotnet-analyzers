using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06819 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06819>();

    public override int Id => 6819;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06819), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06819), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06819), Id);
        }
    }
}

