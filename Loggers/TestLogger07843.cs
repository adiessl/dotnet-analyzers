using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07843 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07843>();

    public override int Id => 7843;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07843), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07843), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07843), Id);
        }
    }
}

