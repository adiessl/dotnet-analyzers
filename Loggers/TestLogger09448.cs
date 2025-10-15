using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09448 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09448>();

    public override int Id => 9448;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09448), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09448), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09448), Id);
        }
    }
}

