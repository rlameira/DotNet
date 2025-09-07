using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Controllers;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Services;
using System.Configuration;
using System.Threading.Tasks;

namespace MonitorCtrlID;

public partial class FrmPrincipal : Form
{
  readonly ControlIdModel _controlID;
  readonly FBDBContexto _contexto;
  readonly ControlIdService _service;
  readonly ControlIdController _controller;  

  //ControlIdModel _controlIdModel = new ControlIdModel();  

  //public FrmPrincipal(ControlIdModel controlId, ControlIdService service, ControlIdController controller)
  public FrmPrincipal(string connString)
  {
    _contexto = new FBDBContexto(connString);
    _controlID = new ControlIdModel();

    _controlID.Codigo = Convert.ToInt32(ConfigurationManager.AppSettings["DeviceCode"]);
    _controlID.Name = ConfigurationManager.AppSettings["DeviceName"];
    _controlID.Ip = ConfigurationManager.AppSettings["DeviceIp"];
    _controlID.Porta = Convert.ToInt32(ConfigurationManager.AppSettings["DevicePorta"]);
    _controlID.SSL = (ConfigurationManager.AppSettings["DeviceSSL"] == "SIM");
    _controlID.User = ConfigurationManager.AppSettings["DeviceUser"];
    _controlID.Password = ConfigurationManager.AppSettings["DevicePassword"];
    _controlID.EntradaSaida = ConfigurationManager.AppSettings["DeviceEntradaSaida"];
    _controlID.PastaDeFotos = ConfigurationManager.AppSettings["PastaDeFotos"];
    _controlID.NumeroUsuariosPorCiclo = Convert.ToInt32(ConfigurationManager.AppSettings["NumeroUsersPorCiclo"]);

    _controlID.ImportaAcessos = (ConfigurationManager.AppSettings["ImportaAcessos"] == "SIM");
    _controlID.LiberaAcademia = (ConfigurationManager.AppSettings["LiberaAcademia"] == "SIM");
    _controlID.LiberaClube = (ConfigurationManager.AppSettings["LiberaClube"] == "SIM");

    _service = new ControlIdService(_controlID, _contexto);
    _controller = new ControlIdController(_controlID, _service);

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
    string tempoTimer = ConfigurationManager.AppSettings["TempoTimer"];

    stsLblIP.Text = $"{_controlID.Ip}:{_controlID.Porta} ({_controlID.EntradaSaida}) {_controlID.Name}";

    AddMsg($"Conectando...");
    //var _controller = new ControlIdController(controlID, service);
    var msg = _controller.Conectar();

    AddMsg($"Conectar: {msg}");
    StsLblSession.Text = _controlID.Session;

    if (msg.StartsWith("OK"))
    {
      tmrFluxo.Interval = Convert.ToInt32(tempoTimer);

      AddMsg($"Ajustando Data e Hora...");
      msg = _controller.AjustarDataEHora(DateTime.Now);
      AddMsg($"Ajustar Data e Hora: {msg}");
      Fluxo();
    }
  }

  private async Task Fluxo()
  {
    tmrFluxo.Enabled = false;
    txtBxMesagem.Clear();
    AddMsg("Fluxo");

    var saveChanges = true;
    if (_controlID.ImportaAcessos)
    {
      await ImportarRegistros(saveChanges);
      Thread.Sleep(100);
    }
    //
    await IncluirUser(saveChanges);
    //
    await ExcluirUser(saveChanges);
    

    //if (_controlID.LiberaClube)
    //{
    //  LiberaClube();
    //}

    //if (_controlID.LiberaAcademia)
    //{
    //  LiberaAcademia();
    //}

    try
    {
      _contexto.SaveChanges();
      Thread.Sleep(100);
    }
    catch (Exception ex) { 
      //
    }

    
    //

    tmrFluxo.Enabled = true;
  }

  //private void LiberaAcademia()
  //{
  //  var msg = "Liberando Acesso a Academia...";
  //  AddMsg($"{msg}");
  //  msg = _controller.LiberaAcademia();
  //  AddMsg($"{msg}");
  //}

  //private void LiberaClube()
  //{
  //  var msg = "Liberando Acesso ao Clube...";
  //  AddMsg($"{msg}");
  //  msg = _controller.LiberaClube();
  //  AddMsg($"{msg}");
  //}

  private async Task<string> ImportarRegistros(bool saveChanges = true)
  {
    //
    AddMsg($"Importando Registros...");
    var msg = await _controller.ImportarRegistros(saveChanges);
    AddMsg($"{msg}");

    if (msg.Contains("Invalid session"))
    {
      Conecta();
    }
    return msg;
  }
  private async Task<string> IncluirUser(bool saveChanges = true)
  {
    //
    AddMsg($"Incluindo Usuários...");
    
    var msg = await _controller.IncluirUsuariosOperacao(_controlID.NumeroUsuariosPorCiclo, saveChanges);
    AddMsg($"{msg}");
    Thread.Sleep(100);
    return msg;
  }
  private async Task<string> ExcluirUser(bool saveChanges = true)
  {
    AddMsg($"Excluindo Usuários...");
    var msg = await _controller.ExcluirUsuariosOperacao(_controlID.NumeroUsuariosPorCiclo, saveChanges);
    AddMsg($"{msg}");
    Thread.Sleep(100);

    return msg;
  }

  private void AddMsg(string msg)
  {
    txtBxMesagem.AppendText($"{DateTime.Now: dd/MM/yyyy HH:mm:ss} {msg} {Environment.NewLine}");
  }

  private void FrmPrincipal_Shown(object sender, EventArgs e)
  {
    //Registrosativo registros = new Registrosativo();

    //registros.Codpessoavisitada = 0;
    //registros.Codpessoavisitante = 123456;
    //registros.Dataehora = DateTime.Now;
    //registros.Data = registros.Dataehora.Value.Date;
    //registros.Hora = registros.Dataehora.Value.TimeOfDay;
    //registros.Codequipamento = _controlID.Codigo;
    //registros.EntradaSaida = _controlID.EntradaSaida;
    //registros.Codempresa = 1;
    //registros.Sensor = 0;
    //registros.Inoutstate = 0;
    //registros.Evento = 0;

    //RegistrosAtivosService registrosService = new RegistrosAtivosService(_contexto);
    //registrosService.Add(registros);

    Conecta();
    //Fluxo();
  }
}
