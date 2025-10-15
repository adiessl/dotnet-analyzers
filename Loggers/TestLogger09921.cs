using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09921 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09921>();

    public override int Id => 9921;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09921), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09921), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09921), Id);
        }
    }
}

