using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08210 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08210>();

    public override int Id => 8210;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08210), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08210), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08210), Id);
        }
    }
}

