using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07568 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07568>();

    public override int Id => 7568;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07568), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07568), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07568), Id);
        }
    }
}

