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


    // Recupera a connection string
    string connString = ConfigurationManager.ConnectionStrings["FirebirdDb"].ConnectionString;


    Application.Run(new FrmPrincipal(connString));
    }    
}