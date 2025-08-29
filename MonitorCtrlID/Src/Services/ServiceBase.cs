using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;

namespace MonitorCtrlID.src.Services
{
  public class ServiceBase<T>(FBDBContexto _context) : IServiceBase<T> where T : class
  {
    //protected readonly FBDBContexto _context;

    //public ServiceBase(FBDBContexto context)
    //{
    //  _context = context;
    //}

    public virtual List<T> GetAll(int top = 0)
    {
      var query = _context.Set<T>().AsQueryable();

      if (top > 0)
        query = query.Take(top);

      //return query.ToList();
      return [.. query];
    }

    public virtual T? Get(params object[] keys)
    {
      return _context.Set<T>().Find(keys);
    }

    public virtual void Add(T entity)
    {
      _context.Set<T>().Add(entity);
      _context.SaveChanges();
    }

    public virtual void Update(T entity)
    {
      _context.Set<T>().Update(entity);
      _context.SaveChanges();
    }

    public virtual void Delete(T entity)
    {
      _context.Set<T>().Remove(entity);
      _context.SaveChanges();
    }
  }
}

