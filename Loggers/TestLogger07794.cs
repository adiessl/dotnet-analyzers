using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07794 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07794>();

    public override int Id => 7794;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07794), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07794), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07794), Id);
        }
    }
}

