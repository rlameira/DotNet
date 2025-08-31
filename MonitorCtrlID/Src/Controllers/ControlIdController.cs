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

    public string ImportarRegistros()
    {
      return _service.ImportarRegistros(_controlId);
    }

    public Task<string> IncluirUsuariosOperacao(int top)
    {
      return _service.IncluirUsuariosOperacao(top);
    }

    public Task<string> ExcluirUsuariosOperacao(int top)
    {
      return _service.IncluirUsuariosOperacao(top);
    }

    public string AjustarDataEHora(DateTime dt)
    {
      return _service.AjustarDataEHora(dt);
    }
  }
}
