using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07964 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07964>();

    public override int Id => 7964;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07964), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07964), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07964), Id);
        }
    }
}

