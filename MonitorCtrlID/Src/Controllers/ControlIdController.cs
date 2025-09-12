using MonitorCtrlID.Src.ControlId.Model;
using MonitorCtrlID.Src.Middleware;
using MonitorCtrlID.Src.Models;
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
    public async Task<string> Conectar()
    {
      await Logger.MesageLog("Controller Conectar", 1);
      return await _service.Conectar();
    }


    public async Task<string> Desconectar()
    {
      await Logger.MesageLog("Controller Desconectar", 1);
      return await _service.Desconectar();
    }

    public async Task<string> ImportarRegistros(bool saveChanges = true)
    {
      await Logger.MesageLog("ImportarRegistros controller", 9);
      return await _service.ImportarRegistros(_controlId, saveChanges);
    }

    public async Task<List<PesssoaEquipamentoModel>> IncluirUsuariosOperacao(int top, bool saveChanges = true)
    {
      await Logger.MesageLog("Controller IncluirUsuariosOperacao", 1);
      var listPessoasEquip = await _service.IncluirUsuariosOperacao(top, saveChanges);
      return listPessoasEquip;
    }

    public async Task<string> ExcluirUsuariosOperacao(int top, bool saveChanges = true)
    {
      await Logger.MesageLog("Controller ExcluirUsuariosOperacao", 1);
      var msg = await _service.ExcluirUsuariosOperacao(top, saveChanges);
      return msg;
    }

    public async Task<string> AjustarDataEHora(DateTime dt)
    {
      await Logger.MesageLog("Controller AjustarDataEHora", 1);
      return await _service.AjustarDataEHora(dt);
    }
  }
}
