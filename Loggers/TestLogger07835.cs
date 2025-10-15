using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07835 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07835>();

    public override int Id => 7835;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07835), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07835), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07835), Id);
        }
    }
}

