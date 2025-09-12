using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;
using MonitorCtrlID.Src.Middleware;

namespace MonitorCtrlID.Src.Services
{
  public class OperacaoService : IOperacaoService
  {
    //protected readonly List<int> _pessoasIncluidas;
    protected readonly FBDBContexto _contexto;
    
    public OperacaoService(FBDBContexto contexto)
    {
      _contexto = contexto;
      //_pessoasIncluidas = new List<int>();
    }

    public List<Operacao> GetExclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _contexto.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "E")
          .OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    public List<Operacao> GetInclusoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _contexto.Operacoes
          .Where(o => (codEquipamento == 0 || o.CodEquipamento == codEquipamento) && o.Operacao1 == "I")
          .OrderByDescending(o => o.DataHora);


      if (top > 0)
        query = query.Take(top);


     // _pessoasIncluidas.AddRange(query.Select(o => o.CodPessoa));

      return query.ToList();
    }

    public async void ExcluirOperacao(Operacao operacao, bool saveChanges = true)
    {
      try
      {
        _contexto.Operacoes.Remove(operacao);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }

      }
      catch (Exception ex)
      {
        await Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    List<Operacao> IOperacaoService.GetUltimasOperacoes(int codEquipamento, int top)
    {
      IQueryable<Operacao> query = _contexto.Operacoes.OrderByDescending(o => o.DataHora);

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    List<Operacao> IServiceBase<Operacao>.GetAll(int top)
    {
      return _contexto.Operacoes
    .ToList();
    }

    // Buscar operações por data
    public List<Operacao> GetByDate(DateTime data, int top = 0)
    {
      IQueryable<Operacao> query = _contexto.Operacoes
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

    void IServiceBase<Operacao>.Add(Operacao entity, bool saveChanges = true)
    {
      try
      {
        _contexto.Operacoes.Add(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    // Atualizar operação existente
    void IServiceBase<Operacao>.Update(Operacao entity, bool saveChanges = true)
    {
      try
      {
        _contexto.Operacoes.Update(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    // Remover operação
    void IServiceBase<Operacao>.Delete(Operacao entity, bool saveChanges = true)
    {
      try
      {
        _contexto.Operacoes.Remove(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    public void RemoveOperacoes(List<Operacao> operacoes, bool saveChanges = true)
    {
      try
      {
        _contexto.Operacoes.RemoveRange(operacoes);
        if (saveChanges)
        {
          //_contexto.SaveChanges();
          _contexto.SaveChangesAsync();
        }
      }
      catch (Exception ex)
      {
        Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
      }
    }
  }

}
