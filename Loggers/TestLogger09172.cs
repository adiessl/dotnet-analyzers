using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09172 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09172>();

    public override int Id => 9172;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09172), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09172), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09172), Id);
        }
    }
}

