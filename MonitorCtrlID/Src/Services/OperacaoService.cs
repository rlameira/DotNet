using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MonitorCtrlID.Src.Services
{

  public class OperacaoService(FBDBContexto context) : IOperacaoService
  {
    //private readonly FBDBContexto _context;
    //public OperacaoService(FBDBContexto context)
    //{
    //  _context = context;
    //}

    public List<Operacao> GetExclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = context.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "E")
          .OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    public List<Operacao> GetInclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = context.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "I")
          .OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    public void ExcluirOperacao(Operacao operacao)
    {
      context.Operacoes.Remove(operacao);
      context.SaveChanges();
    }

    List<Operacao> IOperacaoService.GetUltimasOperacoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = context.Operacoes.OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    List<Operacao> IServiceBase<Operacao>.GetAll(int top)
    {
      return context.Operacoes
    .ToList();
    }

    // Buscar operações por data
    public List<Operacao> GetByDate(DateTime data, int top = 0)
    {
      IQueryable<Operacao> query = context.Operacoes
          .Where(o => o.DataHora.HasValue && o.DataHora.Value.Date == data.Date)
          .OrderBy(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      return query.ToList();
    }

    Operacao? IServiceBase<Operacao>.Get(params object[] keys)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Operacao>.Add(Operacao entity)
    {
      context.Operacoes.Add(entity);
      context.SaveChanges();
    }

    // Atualizar operação existente
    void IServiceBase<Operacao>.Update(Operacao entity)
    {
      context.Operacoes.Update(entity);
      context.SaveChanges();
    }

    // Remover operação
    void IServiceBase<Operacao>.Delete(Operacao entity)
    {
      context.Operacoes.Remove(entity);
      context.SaveChanges();
    }
  }

}
