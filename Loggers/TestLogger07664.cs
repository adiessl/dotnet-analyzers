using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07664 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07664>();

    public override int Id => 7664;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07664), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07664), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07664), Id);
        }
    }
}

