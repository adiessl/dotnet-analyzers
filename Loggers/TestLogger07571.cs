using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07571 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07571>();

    public override int Id => 7571;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07571), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07571), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07571), Id);
        }
    }
}

