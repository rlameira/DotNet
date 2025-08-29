namespace MonitorCtrlID.Src.ControlId.Model
{
  public partial class ControlIdModel
  {
    public int Codigo { get; set; }
    public string Url { get; set; }
    public int Porta  { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public string Session { get; set; }
    public bool SSL { get; set; }

  }
}
