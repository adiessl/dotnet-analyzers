using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09416 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09416>();

    public override int Id => 9416;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09416), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09416), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09416), Id);
        }
    }
}

