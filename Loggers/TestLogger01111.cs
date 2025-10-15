using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01111 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01111>();

    public override int Id => 1111;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01111), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01111), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01111), Id);
        }
    }
}

