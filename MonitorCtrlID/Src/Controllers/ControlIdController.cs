using FirebirdSql.Data.Services;
using MonitorCtrlID.Src.Services;

namespace MonitorCtrlID.Src.Controllers
{
  internal class ControlIdController(ControlIdService _service)
  {
    //protected readonly ControlIdService _service;
    //public ControlIdController(ControlIdService _service);
    //{
    //  _service = service;
    //}
    public string Conectar()
    {
      return _service.Conectar();
    }

    public string AjustarDataEHora(DateTime dt)
    {
      return _service.AjustarDataEHora(dt);
    }
  }
}
