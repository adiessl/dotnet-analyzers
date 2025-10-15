using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01855 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01855>();

    public override int Id => 1855;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01855), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01855), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01855), Id);
        }
    }
}

