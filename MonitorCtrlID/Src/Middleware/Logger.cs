using System.Configuration;

namespace MonitorCtrlID.Src.Middleware
{
  public static class Logger
  {
    public static void LogError(Exception ex)
    {
      string logFile = "log.txt";
      string logMessage = $"{DateTime.Now: dd/MM/yy HH:mm:ss} {ex.Message} {{Environment.NewLine}} {ex.StackTrace} {Environment.NewLine}";
      File.AppendAllText(logFile, logMessage);
    }


    public static void MesageLog(string msg, int level)
    {
      var errorLevel = Convert.ToInt32(ConfigurationManager.AppSettings["LogErrorLevel"]);

      if (level >= errorLevel)
      {
        string logFile = "log.txt";
        string logMessage = $"{DateTime.Now: dd/MM/yy HH:mm:ss} {msg} {Environment.NewLine}";
        File.AppendAllText(logFile, logMessage);
      }
    }
  }
}
