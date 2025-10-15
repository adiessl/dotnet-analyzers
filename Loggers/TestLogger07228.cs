using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07228 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07228>();

    public override int Id => 7228;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07228), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07228), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07228), Id);
        }
    }
}

