using System.Configuration;

namespace MonitorCtrlID.Src.Middleware
{
  public class Logger
  {
    public static async Task LogError(Exception ex)
    {
      var logPath = ConfigurationManager.AppSettings["PastaDeLogs"];
      var deviceId = ConfigurationManager.AppSettings["DeviceCode"];
      string logFile = $"{logPath}log_{deviceId}.txt";

      string logMessage = $"{DateTime.Now: dd/MM/yy HH:mm:ss} {ex.Message} {{Environment.NewLine}} {ex.StackTrace} {Environment.NewLine}";
      await File.AppendAllTextAsync(logFile, logMessage);
    }


    public static async Task MesageLog(string msg, int level)
    {
      var errorLevel = Convert.ToInt32(ConfigurationManager.AppSettings["LogErrorLevel"]);
      
      if (level >= errorLevel)
      {
        var logPath = ConfigurationManager.AppSettings["PastaDeLogs"];
        var deviceId = ConfigurationManager.AppSettings["DeviceCode"];
        string logFile = $"{logPath}log_{deviceId}.txt";

        string logMessage = $"{DateTime.Now: dd/MM/yy HH:mm:ss} {msg} {Environment.NewLine}";
        await File.AppendAllTextAsync(logFile, logMessage);
      }
    }
  }
}
