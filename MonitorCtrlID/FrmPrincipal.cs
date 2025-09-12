using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Controllers;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Middleware;
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
    //this.Name = _controlID.Name.Replace(" ", "");
    this.Text = $"{_controlID.Name} {_controlID.Codigo}" ;
  }

  private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {
  }

  private async void tmrFluxo_Tick(object sender, EventArgs e)
  {
    tmrFluxo.Enabled = false; // pausa o timer para evitar chamadas concorrentes

    await Fluxo(); // executa sua lógica assíncrona

    tmrFluxo.Enabled = true; // reativa o timer depois que terminar
  }


  private async Task Conecta()
  {
    await Logger.MesageLog("Conecta", 1);
    stsLblHoraConexao.Text = $"Conexao: {DateTime.Now: dd/MM HH:mm}";
    bool exibeDataEHora = false;
    bool exibeHora = true;
    //
    _controlID.CiclosReconexao = Convert.ToInt32(ConfigurationManager.AppSettings["CiclosReconexao"]);
    stsLblReconectar.Text = $"{_controlID.CiclosReconexao}";

    string tempoTimer = ConfigurationManager.AppSettings["TempoTimer"];

    stsLblIP.Text = $"{_controlID.Ip}:{_controlID.Porta} ({_controlID.EntradaSaida}) {_controlID.Name}";

    await AddMsg($"Conectando...", exibeDataEHora, exibeHora);
    //var _controller = new ControlIdController(controlID, service);
    var msg = await _controller.Conectar();

    await AddMsg($"Conectar: {msg}", exibeDataEHora, exibeHora);
    StsLblSession.Text = _controlID.Session;

    if (msg.StartsWith("OK"))
    {
      tmrFluxo.Interval = Convert.ToInt32(tempoTimer);

      await AddMsg($"Ajustando Data e Hora...", exibeDataEHora, exibeHora);
      msg = await _controller.AjustarDataEHora(DateTime.Now);
      await AddMsg($"Ajustar Data e Hora: {msg}", exibeDataEHora, exibeHora);
      await Fluxo();
      tmrFluxo.Enabled = true;
    }
  }

   private async Task Fluxo()
  {
    stsLblReconectar.Text = $"{_controlID.CiclosReconexao}";
    tmrFluxo.Enabled = false;
    await Logger.MesageLog("Fluxo", 1);

    bool exibeDataEHora = false;
    bool exibeHora = true;
   
    txtBxMesagem.Clear();
    AddMsg("Fluxo", exibeDataEHora, exibeHora);

    var saveChanges = false;
    if (_controlID.ImportaAcessos)
    {
      await ImportarRegistros(saveChanges);
    }
    //
    await Task.Delay(100);
    await IncluirUser(saveChanges);
    //
    await Task.Delay(100);
    await ExcluirUser(saveChanges);

    try
    {
       await Logger.MesageLog("SaveChanges", 9);
      _contexto.SaveChanges();
      await Task.Delay(100);
    }
    catch (Exception ex) {
      //
      await Logger.LogError(ex);
    }
    //
    _controlID.CiclosReconexao = _controlID.CiclosReconexao - 1;
    if (_controlID.CiclosReconexao<0)
    {
      await Desconectar();
      await Conecta();
    }
  }

  private async Task Desconectar()
  {
    bool exibeDataEHora = false;
    bool exibeHora = true;
    await AddMsg("Desconectar", exibeDataEHora, exibeHora);
    var msg = await _controller.Desconectar();
    await AddMsg(msg, exibeDataEHora, exibeHora);
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
    await Logger.MesageLog("ImportarRegistros", 1);
    //
    bool exibeDataEHora = false;
    bool exibeHora = true;
    AddMsg($"Importando Registros...", exibeDataEHora, exibeHora);

    var msg = await _controller.ImportarRegistros(saveChanges);

    AddMsg($"{msg}", exibeDataEHora, exibeHora);

    if (msg.Contains("Invalid session"))
    {
      Conecta();
    }
    return msg;
  }
  private async Task<string> IncluirUser(bool saveChanges = true)
  {
    await Logger.MesageLog("IncluirUser", 1);
    //
    bool exibeDataEHora = false;
    bool exibeHora = true;
    var msg = "";
    AddMsg($"Incluindo Usuários...", exibeDataEHora, exibeHora);

    var listPessoasEquip = await _controller.IncluirUsuariosOperacao(_controlID.NumeroUsuariosPorCiclo, saveChanges);
    await Task.Delay(100);
    exibeHora = false;
    foreach (var pessoaEquipamento in listPessoasEquip)
    {
      string nome20 = pessoaEquipamento.Nome.Length > 20 ? pessoaEquipamento.Nome.Substring(0, 20) : pessoaEquipamento.Nome.PadRight(20);

      
      msg = $"Id:{pessoaEquipamento.CodPessoa.ToString("D9")} Nomes: {nome20} Msg: {pessoaEquipamento.Msg}";
      AddMsg(msg, exibeDataEHora, exibeHora);
    }

    msg = "FIM";
    return msg;
  }
  private async Task<string> ExcluirUser(bool saveChanges = true)
  {
    await Logger.MesageLog("ExcluirUser", 1);
    bool exibeDataEHora = false;
    bool exibeHora = true;
    AddMsg($"Excluindo Usuários..." ,exibeDataEHora ,exibeHora);
    var msg = await _controller.ExcluirUsuariosOperacao(_controlID.NumeroUsuariosPorCiclo, saveChanges);
    AddMsg($"{msg}", exibeDataEHora, exibeHora);
    await Task.Delay(100);

    msg = "FIM";
    return msg;
  }

  private async Task AddMsg(string msg, bool exibeDataEHora = true, bool exibeHora = true)
  {
    await Logger.MesageLog(msg, 9);
    if (exibeDataEHora)
    {
      txtBxMesagem.AppendText($"{DateTime.Now: dd/MM/yy HH:mm} {msg} {Environment.NewLine}");
    }
    else if (exibeHora)
    {
      txtBxMesagem.AppendText($"{DateTime.Now: HH:mm:ss} {msg} {Environment.NewLine}");
    }
    else
    {
      txtBxMesagem.AppendText($"{msg} {Environment.NewLine}");
    }      
  }

  private async void FrmPrincipal_Shown(object sender, EventArgs e)
  {
    await Logger.MesageLog("FrmPrincipal_Shown", 2);
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
    stsLblHoraAbertura.Text = $"Abertura: {DateTime.Now: dd/MM HH:mm}";
    await Conecta();
    //Fluxo();
  }
}
