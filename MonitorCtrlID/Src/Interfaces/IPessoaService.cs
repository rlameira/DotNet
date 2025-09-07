using MonitorCtrlID.src.Models;

namespace MonitorCtrlID.Src.Interfaces
{
  public interface IPessoaService : IServiceBase<Pessoa>
  {
    public List<Pessoa> GetPessasAcademia();

    public List<Pessoa> GetPessasClube();
  }
}
