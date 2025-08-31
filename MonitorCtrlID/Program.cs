using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Controllers;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Services;

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

    Application.Run(new FrmPrincipal());
    }    
}