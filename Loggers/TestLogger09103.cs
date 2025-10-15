using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09103 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09103>();

    public override int Id => 9103;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09103), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09103), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09103), Id);
        }
    }
}

