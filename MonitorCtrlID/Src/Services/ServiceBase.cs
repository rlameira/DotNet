using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;

namespace MonitorCtrlID.src.Services
{
  public class ServiceBase<T>(FBDBContexto _contexto) : IServiceBase<T> where T : class
  {
    //protected readonly FBDBContexto _context;

    //public ServiceBase(FBDBContexto context)
    //{
    //  _context = context;
    //}

    public virtual List<T> GetAll(int top = 0)
    {
      var query = _contexto.Set<T>().AsQueryable();

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    public virtual T? Get(params object[] keys)
    {
      return _contexto.Set<T>().Find(keys);
    }

    public virtual void Add(T entity,bool saveChanges = true)
    {
      try
      {
        _contexto.Set<T>().Add(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    public virtual void Update(T entity, bool saveChanges = true)
    {
      try
      {
        _contexto.Set<T>().Update(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    public virtual void Delete(T entity, bool saveChanges = true)
    {
      try
      {
        _contexto.Set<T>().Remove(entity);
        if (saveChanges)
        {
          _contexto.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }
  }
}

