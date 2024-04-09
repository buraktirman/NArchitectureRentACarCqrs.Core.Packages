using Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Core.CrossCuttingConcerns.Serilog.Messages;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Core.CrossCuttingConcerns.Serilog.Logger;

public class FileLogger : LoggerServiceBase
{
    public FileLogger(IConfiguration configuration)
    {
        FileLogConfiguration logConfig =
            configuration.GetSection("SeriLogConfigurations:FileLogConfiguration")
            .Get<FileLogConfiguration>()
            ?? throw new Exception(SerilogMessages.NullOptionsMessage);

        string logFilePath = string.Format(format: "{0}{1}", arg0: Directory.GetCurrentDirectory() + logConfig.FolderPath, arg1: ".txt");

        Logger = new LoggerConfiguration().WriteTo.File(
            logFilePath, rollingInterval: RollingInterval.Day, //Her gün yeni bir log dosyası oluşturur.
            retainedFileCountLimit: null, //Log dosyalarının saklanma süresi sınırsızdır.
                                          //Log dosyaları bir limite ulaştığında eski log dosyaları silinmez.
            fileSizeLimitBytes: 5000000,
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}"
            ).CreateLogger();
    }
}