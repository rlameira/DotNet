using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Data;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace MonitorCtrlID.Src.Services
{
  internal class ControlIdService(ControlIdModel _controlId)
  {

    //protected readonly ControlIdModel _controlIdModel;

    //public ControlIdService(ControlIdModel controlIdModel)
    //{
    //  _controlIdModel = controlIdModel;
    //}

    public string Conectar()
    {
      string msg;
      try
      {
        _controlId.Url = _controlId.Url.Trim();
        _controlId.Session = null; // erases the previous session (invalida sessão anterior)

        if (_controlId.SSL)
        {
          _controlId.Url = "https://" + _controlId.Url;
          if (_controlId.Porta != 443)
            _controlId.Url += ":" + _controlId.Porta;
        }
        else
        {
          _controlId.Url = "http://" + _controlId.Url;
          if (_controlId.Porta != 80)
            _controlId.Url += ":" + _controlId.Porta;
        }
        _controlId.Url += "/";

        msg = "Device: " + _controlId.Url;

        // See another robust mode to login with serialization of JSON objects in the project "Remote Control" creating structures that are serialized
        // (Veja uma outra forma mais robusta de como poderia ser feito um login com serialização de objetos JSON no projeto de "Controle Remoto" criando estruturas que são serializadas se transformando em strings)
        // https://github.com/controlid/iDAccess/blob/master/ControleRemoto-CS/idAccess.cs
        string response = WebJsonService.Send(_controlId.Url + "login", "{\"login\":\"" + _controlId.User + "\",\"password\":\"" + _controlId.Password + "\"}");
        //AddLog(response);

        // Simple method to get the session
        // (Forma mais simples de pegar a sessão)
        if (response.Contains("session"))
        {
          _controlId.Session = response.Split('"')[3];
          msg = "OK!";

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
        msg = ex.Message;
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

        msg = WebJsonService.Send(_controlId.Url + "set_system_time", cmd, _controlId.Session);
      }
      catch (Exception ex)
      {
        msg = ex.Message;
      }
      return msg;
    }

    public string IncluirUser(ControlIdUserModel user)
    {
      string msg;
      try
      {
        // Using 'string' there are several situations that need to be handled manually do so via to parse JSON is much better
        // (Usando string há várias situações que precisam ser tratadas manualmente por isso fazer via com parse JSON é bem melhor)
        string cmd = "{" +
            "\"object\" : \"users\"," +
            "\"values\" : [{" +
                    (user.Id.ToString() == "" ? "" : ("\"id\" :" + user.Id.ToString() + ",")) + // optional (opcional)
                    "\"name\" :\"" + user.Name + "\"," +
                    "\"registration\" : \"" + user.Registration + "\"" +
                "}]" +
            "}";
        msg = WebJsonService.Send(_controlId.Url + "create_objects", cmd, _controlId.Session);
      }
      catch (Exception ex)
      {
        msg = ex.Message;
      }
      return msg;
    }

    public string ExcluirUser(ControlIdUserModel user)
    {
      string msg;
      try
      {
        long id = long.Parse(user.Id.ToString());
        msg = WebJsonService.Send(_controlId.Url + "destroy_objects", "{\"object\":\"users\",\"where\":{\"users\":{\"id\":[" + id + "]}}}", _controlId.Session);
      }
      catch (Exception ex)
      {
        msg = ex.Message;
      }
      return msg;
    }

    public async Task<string> AlterarUser(ControlIdUserModel user)
    {
      string msg;
      try
      {
        long id = long.Parse(user.Id.ToString());
        string cmd = "{" +
            "\"object\" : \"users\"," +
            "\"where\":{\"users\":{\"id\":[" + id + "]}}," +
            "\"values\" : {" +
                    "\"name\" :\"" + user.Name + "\"," +
                    "\"registration\" : \"" + user.Registration + "\"" +
                "}" +
            "}";

        msg = WebJsonService.Send(_controlId.Url + "modify_objects", cmd, _controlId.Session);

        string fotoFilename = "";

        if (!string.IsNullOrEmpty(fotoFilename))
        { 
          string filePath = fotoFilename;

          byte[] imageBytes = await Task.Run(() => File.ReadAllBytes(filePath));

          long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();

          var client = new HttpClient();
          string url = $"{_controlId.Url}user_set_image.fcgi?user_id={id}&session={_controlId.Session}&timestamp={timestamp}";

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
      }
      catch (Exception ex)
      {
        msg = ex.Message;
      }
      return msg;
    }

  }
}
