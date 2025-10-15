using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01831 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01831>();

    public override int Id => 1831;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01831), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01831), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01831), Id);
        }
    }
}

