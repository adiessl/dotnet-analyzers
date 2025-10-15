using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07728 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07728>();

    public override int Id => 7728;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07728), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07728), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07728), Id);
        }
    }
}

