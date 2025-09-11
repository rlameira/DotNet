namespace MonitorCtrlID.Src.ControlId.Model
{
  public partial class ControlIdModel
  {
    public int Codigo { get; set; } = 0;
    public string Name { get; set; } = "";
    public string Ip { get; set; } = "";
    public string Url { get; set; } = "";
    public int Porta { get; set; } = 80;
    public string User { get; set; } = "";
    public string Password { get; set; } = "";
    public string Session { get; set; } = "";
    public bool SSL { get; set; }  = false;
    public string EntradaSaida { get; set; } = "A";
    public bool ImportaAcessos { get; set; } = false;
    public string PastaDeFotos { get; set; } = "";
    public int NumeroUsuariosPorCiclo { get; set; } = 5;
    public DateTime UltimoRegistro { get; set; }
    public bool LiberaAcademia { get; set; } = false;
    public bool LiberaClube { get; set; } = false;

    public int CiclosReconexao { get; set; } = 0;

    

  }
}
