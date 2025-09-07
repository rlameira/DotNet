using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;

namespace MonitorCtrlID.Src.Services
{
  public class PessoaService(FBDBContexto contexto) : IPessoaService
  {
    public void Add(Pessoa entity, bool saveChanges = true)
    {
      throw new NotImplementedException();
    }

    public void Delete(Pessoa entity, bool saveChanges = true)
    {
      throw new NotImplementedException();
    }

    public Pessoa? Get(params object[] keys)
    {
      throw new NotImplementedException();
    }

    public List<Pessoa> GetAll(int top = 0)
    {
      throw new NotImplementedException();
    }

    public List<Pessoa> GetPessasAcademia()
    {
      var pessas = contexto.Pessoas
        .Where(p => p.Liberaacademia == "S")
        .ToList();
      return pessas;
    }

    public List<Pessoa> GetPessasClube()
    {
      var pessas = contexto.Pessoas
        .Where(p => p.Liberaclube == "S")
        .ToList();
      return pessas;
    }

    public void Update(Pessoa entity, bool saveChanges = true)
    {
      throw new NotImplementedException();
    }
  }
}
