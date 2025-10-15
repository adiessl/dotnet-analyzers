using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09752 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09752>();

    public override int Id => 9752;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09752), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09752), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09752), Id);
        }
    }
}

