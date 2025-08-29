using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;

namespace MonitorCtrlID.Src.Interfaces
{

  public interface IOperacaoService : IServiceBase<Operacao>
  {
    List<Operacao> GetUltimasOperacoes(int codEquipamento = 0, int top = 5);
  }

  public class OperacaoService(FBDBContexto context) : IServiceBase<Operacao>, IOperacaoService
  {
    //protected readonly FBDBContexto _context;
    //public OperacaoService(FBDBContexto context) {
    //  _context = context;
    //}

    public void Add(Operacao entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(Operacao entity)
    {
      throw new NotImplementedException();
    }

    public Operacao? Get(params object[] keys)
    {
      throw new NotImplementedException();
    }

    public List<Operacao> GetAll(int top = 0)
    {
      throw new NotImplementedException();
    }

    public List<Operacao> GetExclusoes(int codEquipamento, int top)
    {
      throw new NotImplementedException();
    }
    public List<Operacao> GetInclusoes(int codEquipamento, int top)
    {
      throw new NotImplementedException();
    }

    public List<Operacao> GetUltimasOperacoes(int codEquipamento = 0, int top = 5)
    {
      throw new NotImplementedException();
    }

    public void Update(Operacao entity)
    {
      throw new NotImplementedException();
    }
  }

}


