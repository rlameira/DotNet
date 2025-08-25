using System.Configuration;

namespace MonitorCtrlID;

public partial class FrmPrincipal : Form
{
  string deviceIp = ConfigurationManager.AppSettings["DeviceIp"];
  string devicePorta = ConfigurationManager.AppSettings["DevicePorta"];
  string deviceSSL = ConfigurationManager.AppSettings["DeviceSSL"];
  string deviceUser = ConfigurationManager.AppSettings["DeviceUser"];
  string devicePassword = ConfigurationManager.AppSettings["DevicePassword"];
  string deviceEntradaSaida = ConfigurationManager.AppSettings["DeviceEntradaSaida"];
  bool importaAcessos = (ConfigurationManager.AppSettings["ImportaAcessos"] == "SIM");
  string pastaDeFotos = ConfigurationManager.AppSettings["PastaDeFotos"];
  string tempoTimer = ConfigurationManager.AppSettings["TempoTimer"];

  public FrmPrincipal()
  {
    InitializeComponent();
  }

  private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {

  }

  private void tmrFluxo_Tick(object sender, EventArgs e)
  {
    Fluxo();
  }


  private void Conecta()
  {
    stsLblIP.Text = $"{deviceIp}:{devicePorta} ({deviceEntradaSaida})";
    StsLblSession.Text = "";
    Fluxo();
  }

  private void Fluxo()
  {
    tmrFluxo.Enabled = false;
    txtBxMesagem.Clear();
    AddMsg("Fluxo");
    tmrFluxo.Enabled = true;
  }

  private void AddMsg(string msg)
  {
    txtBxMesagem.AppendText($"{DateTime.Now: dd/MM/yyyy HH:mm:ss} {msg} {Environment.NewLine}");
  }

  private void FrmPrincipal_Shown(object sender, EventArgs e)
  {
    Conecta();
  }
}
