using System.Configuration; // necessário para ConfigurationManager

namespace MonitorCtrlID;
static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    ApplicationConfiguration.Initialize();
    // Carrega configuração do appsettings.json

    // Tratamento global de erros para threads UI
    Application.ThreadException += (sender, e) =>
    {
      if (!e.Exception.Message.Contains("The process cannot access the file"))
      {
        LogError(e.Exception);
        //MessageBox.Show("Ocorreu um erro. Verifique o log.txt.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    };

    // Tratamento global para exceções não tratadas (threads não-UI)
    AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
    {
      if (e.ExceptionObject is Exception ex)
      {
        LogError(ex);
      }
    };


    // Recupera a connection string
    string connString = ConfigurationManager.ConnectionStrings["FirebirdDb"].ConnectionString;

    Application.Run(new FrmPrincipal(connString));
  }

  private static void LogError(Exception ex)
  {
    var logPath = ConfigurationManager.AppSettings["PastaDeLogs"];
    var deviceId = ConfigurationManager.AppSettings["DeviceCode"];
    string logFile = $"{logPath}log_Error{deviceId}.txt";

    string logMessage = $"[{DateTime.Now}] {ex.Message}\n{ex.StackTrace}\n\n";
    File.AppendAllText(logFile, logMessage);
  }
}   
