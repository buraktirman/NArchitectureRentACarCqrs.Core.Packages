using Serilog;

namespace Core.CrossCuttingConcerns.Serilog;

public abstract class LoggerServiceBase
{
    protected ILogger Logger { get; set; }

    protected LoggerServiceBase()
    {
        Logger = null;
    }

    protected LoggerServiceBase(ILogger logger)
    {
        Logger = logger;
    }

    public void Verbose(string message) => Logger.Verbose(message); //Detaylı

    public void Fatal(string message) => Logger.Fatal(message); //Kritik

    public void Info(string message) => Logger.Information(message); //Bilgilendirme

    public void Warn(string message) => Logger.Warning(message); //Uyarı

    public void Debug(string message) => Logger.Debug(message); //Hata Ayıklama

    public void Error(string message) => Logger.Error(message); //Hata
}
