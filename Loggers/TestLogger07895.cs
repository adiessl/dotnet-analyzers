using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07895 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07895>();

    public override int Id => 7895;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07895), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07895), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07895), Id);
        }
    }
}

