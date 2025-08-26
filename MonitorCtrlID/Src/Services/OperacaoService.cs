using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;

namespace MonitorCtrlID.Src.Services
{

  public class OperacaoService : IOperacaoService
  {
    private readonly FBDBContexto _context;

    public OperacaoService(FBDBContexto context)
    {
      _context = context;
    }

    public List<Operacao> GetExclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _context.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "E")
          .OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      return query.ToList();
    }

    public List<Operacao> GetInclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _context.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "I")
          .OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      return query.ToList();
    }

    public void ExcluirOperacao(Operacao operacao)
    {
      _context.Operacoes.Remove(operacao);
      _context.SaveChanges();
    }

    List<Operacao> IOperacaoService.GetUltimasOperacoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _context.Operacoes.OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      return query.ToList();
    }

    List<Operacao> IServiceBase<Operacao>.GetAll(int top)
    {
      throw new NotImplementedException();
    }

    Operacao? IServiceBase<Operacao>.Get(params object[] keys)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Operacao>.Add(Operacao entity)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Operacao>.Update(Operacao entity)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Operacao>.Delete(Operacao entity)
    {
      throw new NotImplementedException();
    }
  }

}
