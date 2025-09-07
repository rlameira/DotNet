using FirebirdSql.Data.Services;
using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Services;

namespace MonitorCtrlID.Src.Controllers
{
  //internal class ControlIdController(ControlIdModel controlId, ControlIdService service)
  public class ControlIdController
  {
    protected readonly ControlIdService _service;
    protected readonly ControlIdModel _controlId;
    public ControlIdController(ControlIdModel controlId, ControlIdService service)
    {
      _service = service;
      _controlId = controlId;
    }
    public string Conectar()
    {
      return _service.Conectar();
    }

    public async Task<string> ImportarRegistros(bool saveChanges = true)
    {
      return await _service.ImportarRegistros(_controlId, saveChanges);
    }

    public async Task<string> IncluirUsuariosOperacao(int top, bool saveChanges = true)
    {
      var msg = await _service.IncluirUsuariosOperacao(top, saveChanges);
      return msg;
    }

    public async Task<string> ExcluirUsuariosOperacao(int top, bool saveChanges = true)
    {
      var msg = await _service.ExcluirUsuariosOperacao(top, saveChanges);
      return msg;
    }

    public string AjustarDataEHora(DateTime dt)
    {
      return _service.AjustarDataEHora(dt);
    }
  }
}
