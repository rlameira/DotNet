using Microsoft.VisualBasic.ApplicationServices;
using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Data;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using static MonitorCtrlID.Src.ControlId.IDAccess;

namespace MonitorCtrlID.Src.Services
{
  //internal class ControlIdService(FBDBContexto contexto, ControlIdModel controlId)
  public class ControlIdService
  {

    protected readonly ControlIdModel controlId;
    protected readonly FBDBContexto _contexto;

    protected readonly OperacaoService _operacaoService;
    protected readonly RegistrosAtivosService _registrosService;
    protected readonly PessoaService _pessooaService;

    public ControlIdService(ControlIdModel controlIdModel, FBDBContexto contexto)
    {
      controlId = controlIdModel;
      _contexto = contexto;
      _operacaoService = new OperacaoService(_contexto);
      _registrosService = new RegistrosAtivosService(_contexto);
      _pessooaService = new PessoaService(_contexto);
    }

    public string Conectar()
    {
      string msg;
      try
      {
        controlId.Ip = controlId.Ip.Trim();
        controlId.Session = "Sessão não inicializada"; // erases the previous session (invalida sessão anterior)

        if (controlId.SSL == true)
        {
          controlId.Url = "https://" + controlId.Ip;
          if (controlId.Porta != 443)
            controlId.Url += ":" + controlId.Porta;
        }
        else
        {
          controlId.Url = "http://" + controlId.Ip;
          if (controlId.Porta != 80)
            controlId.Url += ":" + controlId.Porta;
        }
        controlId.Url += "/";

        msg = "Device: " + controlId.Url;

        // See another robust mode to login with serialization of JSON objects in the project "Remote Control" creating structures that are serialized
        // (Veja uma outra forma mais robusta de como poderia ser feito um login com serialização de objetos JSON no projeto de "Controle Remoto" criando estruturas que são serializadas se transformando em strings)
        // https://github.com/controlid/iDAccess/blob/master/ControleRemoto-CS/idAccess.cs

        string response = WebJsonService.Send(controlId.Url + "login", "{\"login\":\"" + controlId.User + "\",\"password\":\"" + controlId.Password + "\"}");

        // Simple method to get the session
        // (Forma mais simples de pegar a sessão)

        if (response.Contains("session"))
        {
          controlId.Session = response.Split('"')[3];
          msg = $"OK: {msg}";

          //// There is still a connection in the application settings to facilitate
          //// (Persiste a conexão nas configurações do aplicativo para facilitar)
          //Settings.Default.ip = txtIP.Text;
          //Settings.Default.port = (int)nmPort.Value;
          //Settings.Default.ssl = chkSSL.Checked;
          //Settings.Default.user = txtUser.Text;
          //Settings.Default.password = txtPassword.Text;
          //Settings.Default.Save();
        }
      }
      catch (Exception ex)
      {
        msg = $"EROR: {ex.Message}";
      }
      return msg;
    }

    public string AjustarDataEHora(DateTime dt)
    {
      string msg;
      try
      {
        string cmd = "{" +
            "\"day\":" + dt.Day +
            ",\"month\":" + dt.Month +
            ",\"year\":" + dt.Year +
            ",\"hour\":" + dt.Hour +
            ",\"minute\":" + dt.Minute +
            ",\"second\":" + dt.Second +
            "}";

        msg = WebJsonService.Send(controlId.Url + "set_system_time", cmd, controlId.Session);
        msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
        msg = $"EROR: {ex.Message}";
      }
      return msg;
    }

    public async Task<string> IncluirUsuariosOperacao(int top,bool saveChanges = true)
    {
      var usuarios = "";
      string msg = "";
      var operacoes = _operacaoService.GetInclusoes(controlId.Codigo, top);
      foreach (var operacao in operacoes)
      {
        ControlIdUserModel user = new ControlIdUserModel();

        user.Id = operacao.CodPessoa;
        user.Name = operacao.Nome != null ? operacao.Nome : "";
        user.begin_time = 1735689600;
        user.end_time = 2082758340;

        usuarios = usuarios + "," + user.Id.ToString();

        try
        {
          msg = await ExcluirUser(user);
        }
        catch (Exception ex)
        {
          msg = $"EROR: {ex.Message}";
        }

        msg = await IncluirUser(user);

        if (msg.StartsWith("OK"))
        {
          msg = await AlterarUser(user);
          //_operacaoService.ExcluirOperacao(operacao, saveChanges);
        }

        //Libera departamento
        UserGroupsModel userGroup = new UserGroupsModel();
        userGroup.user_id = operacao.CodPessoa;
        userGroup.group_id = 1;
        LiberaUsuarioAoDepartamento(userGroup);
      }

      _operacaoService.RemoveOperacoes(operacoes, true);
      Thread.Sleep(100);
      return msg + "(" + usuarios + ")";
      
    }

    public async Task<string> ExcluirUsuariosOperacao(int top, bool saveChanges = true)
    {
      string msg = "";
      var operacoes = _operacaoService.GetExclusoes(controlId.Codigo, top);
      foreach (var operacao in operacoes)
      {
        ControlIdUserModel user = new ControlIdUserModel();

        user.Id = operacao.CodPessoa;
        user.Name = operacao.Nome != null ? operacao.Nome : "";
        user.begin_time = 1735689600;
        user.end_time = 2082758340;

        msg = await ExcluirUser(user);

        if (msg.StartsWith("OK"))
        {
          //_operacaoService.ExcluirOperacao(operacao, saveChanges);
        }
      }
      _operacaoService.RemoveOperacoes(operacoes, true);
      Thread.Sleep(100);
      return msg;
    }


    //public async Task<string> AlterUsuariosOperacao(int top)
    //{
    //  string msg = "";
    //  var operacoes = _operaceosService.GetAlteracoes(controlId.Codigo, top);
    //  foreach (var operacao in operacoes)
    //  {
    //    ControlIdUserModel user = new ControlIdUserModel();

    //    user.Id = operacao.CodPessoa;
    //    user.Name = operacao.Nome != null ? operacao.Nome : "";
    //    user.begin_time = 1735689600;
    //    user.end_time = 2082758340;

    //    msg = await AlterUser(user);

    //    if (msg.StartsWith("OK"))
    //    {
    //      _operacaoService.ExcluirOperacao(operacao);
    //    }
    //  }
    //  return msg;
    //}

    public async Task<string> IncluirUser(ControlIdUserModel user)
    {
      string msg = "";
      try
      {
        // Using 'string' there are several situations that need to be handled manually do so via to parse JSON is much better
        // (Usando string há várias situações que precisam ser tratadas manualmente por isso fazer via com parse JSON é bem melhor)

        string cmd = "{" +
            "\"object\" : \"users\"," +
            "\"values\" : [{" +
                    (user.Id.ToString() == "" ? "" : (
                    $"\"id\" : {user.Id},")) + // optional (opcional)
                    $"\"name\" :\"{user.Name}\"," +
                    $"\"registration\" : \"{user.Registration}\", " +
                    $"\"begin_time\" : {user.begin_time}," +
                    $"\"end_time\" :{user.end_time}" +
                "}]" +
            "}";

        //string cmd = JsonSerializer.Serialize(user);

        msg = WebJsonService.Send(controlId.Url + "create_objects", cmd, controlId.Session);
        msg = $"Usuário {user.Id} Registrado";
        msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
          msg = $"ERROR: {ex.Message}";
      }

      if (msg.Contains("UNIQUE constraint failed"))
      {
        msg = $"OK: Usuário  {user.Id} já Registrado!";
      }

      return msg;
    }


    public async Task<string> AlterUser(ControlIdUserModel user)
    {
      string msg = "";
      try
      {
        string cmd = "{" +
          "\"object\" : \"users\"," +
            $"\"where\":{{\"users\":{{\"id\":[{user.Id}]}}}}," +
            "\"values\" : [{" +
                    $"\"name\" :\"{user.Name}\"," +
                    $"\"registration\" : \"{user.Registration}\"," +
                    $"\"begin_time\" : {user.begin_time}," +
                    $"\"end_time\" :{user.end_time}" +
                    "}]" +
        "}";
        //AddLog(WebJson.Send(urlDevice + "modify_objects", cmd, session));
        msg = WebJsonService.Send(controlId.Url + "modify_objects", cmd, controlId.Session);
        msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
        msg = $"ERROR: {ex.Message}";
      }
      return msg;
    }


    public async Task<string> AlterUserGroups(ControlIdUserModel user)
    {
      //user_groups
      //{ "user_groups":[{ "user_id":3067,"group_id":1}]}

      string msg = "";
      try
      {
        string cmd = "{" +
          "\"object\" : \"user_groups\"," +
            "\"values\" : [{" +
                    $"\"name\" :\"{user.Name}\"," +
                    $"\"registration\" : \"{user.Registration}\"," +
                    $"\"begin_time\" : {user.begin_time}," +
                    $"\"end_time\" :{user.end_time}" +
                    "}]" +
        "}";




        //AddLog(WebJson.Send(urlDevice + "modify_objects", cmd, session));
        msg = WebJsonService.Send(controlId.Url + "modify_objects", cmd, controlId.Session);
        msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
        msg = $"ERROR: {ex.Message}";
      }
      return msg;
    }


    public async Task<string> ExcluirUser(ControlIdUserModel user)
    {
      string msg;
      try
      {
        long id = long.Parse(user.Id.ToString());
        msg = WebJsonService.Send(controlId.Url + "destroy_objects", "{\"object\":\"users\",\"where\":{\"users\":{\"id\":[" + id + "]}}}", controlId.Session);
        msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
        msg = $"EROR: {ex.Message}";
      }
      return msg;
    }

    public async Task<string> AlterarUser(ControlIdUserModel user)
    {
      string msg;
      try
      {
        long id = long.Parse(user.Id.ToString());

        string fotoFilename = $"{controlId.PastaDeFotos}USB{user.Id.ToString().PadLeft(9, '0')}.jpg";

        if (!string.IsNullOrEmpty(fotoFilename) && File.Exists(fotoFilename))
        {

          //string cmd = "{" +
          //  "\"object\" : \"users\"," +
          //  "\"where\":{\"users\":{\"id\":[" + id + "]}}," +
          //  "\"values\" : {" +
          //          "\"name\" :\"" + user.Name + "\"," +
          //          "\"registration\" : \"" + user.Registration + "\"" +
          //      "}" +
          //  "}";

          //msg = WebJsonService.Send(controlId.Url + "modify_objects", cmd, controlId.Session);

          string filePath = fotoFilename;

          byte[] imageBytes = await Task.Run(() => File.ReadAllBytes(filePath));

          long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();

          var client = new HttpClient();
          string url = $"{controlId.Url}user_set_image.fcgi?user_id={id}&session={controlId.Session}&timestamp={timestamp}";

          var content = new ByteArrayContent(imageBytes);
          content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
          var response = await client.PostAsync(url, content);

          if (response.IsSuccessStatusCode)
          {
            await response.Content.ReadAsStringAsync();
            msg = "Foto cadastrada com sucesso!";
          }
          else
          {
            await response.Content.ReadAsStringAsync();
            msg = "Erro ao cadastrar foto.";
          }
        }
        else
        {
          msg = $"{fotoFilename} não existe.";
        }
          msg = $"OK: {msg}";
      }
      catch (Exception ex)
      {
        msg = $"ERROR: {ex.Message}";
      }
      return msg;
    }

    public async Task<string> ImportarRegistros(ControlIdModel controlId, bool saveChances = true)
    {
      var logsProcessados = 0;
      var msg = "";

      var registroAtivo = _registrosService.GetUltimoByCodEquip(controlId.Codigo);
      controlId.UltimoRegistro = DateTime.MinValue.Date;
      if (registroAtivo != null)
      {
        controlId.UltimoRegistro = (registroAtivo.Dataehora ?? DateTime.MinValue).Date;
      }
      try
      {
        var list = WebJsonService.Send<ResultList>(controlId.Url + "load_objects", "{\"object\":\"access_logs\"}", controlId.Session); // Consulte a documentação para fazer 'Where'
        //for (int i = 0; i < list.access_logs.Length; i++)
        foreach (var log in list.access_logs)
        {
          if ((log.Date > controlId.UltimoRegistro) && (log.user_id > 0))
          {
            Registrosativo registrosativo = new Registrosativo();
            registrosativo.Codpessoavisitada = 0;
            registrosativo.Codpessoavisitante = Convert.ToInt32(log.user_id);
            registrosativo.Codequipamento = controlId.Codigo;
            registrosativo.EntradaSaida = controlId.EntradaSaida;
            registrosativo.Dataehora = log.Date;
            registrosativo.Data = log.Date.Date;
            registrosativo.Hora = log.Date.TimeOfDay;
            registrosativo.Codempresa = 1;
            registrosativo.Sensor = 0;
            registrosativo.Inoutstate = 0;
            registrosativo.Evento = 0;

            _registrosService.Add(registrosativo, saveChances);
            logsProcessados++;
          }
        }
        //AddLog(sb.ToString());
        msg = $"OK {logsProcessados}/{list.access_logs.Count()}";
      }
      catch (Exception ex)
      {
        msg = $"ERRO: {ex.Message}";
      }
      return msg;
    }

    public string LiberaUsuarioAoDepartamento(UserGroupsModel userGroup)
    {
      string msg = "";
      try
      {
        //var pessoas = _pessooaService.GetPessasAcademia();
        var listUserGroups = new List<UserGroupsModel>();
        userGroup.group_id = 1;
        listUserGroups.Add(userGroup);

        var payload = new
        {
          @object = "user_groups",
          values = listUserGroups
        };

        string cmd = JsonSerializer.Serialize(payload);

        //msg = WebJsonService.Send(controlId.Url + "modify_objects", cmd, controlId.Session);
        msg = WebJsonService.Send(controlId.Url + "create_objects", cmd, controlId.Session);
        msg = $"OK: {msg}";

      }
      catch (Exception ex)
      {
        msg = $"ERROR: {ex.Message}";
      }
      return msg;
    }
  }
}
