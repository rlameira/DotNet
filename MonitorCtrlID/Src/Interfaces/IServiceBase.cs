using MonitorCtrlID.Src.Data;

namespace MonitorCtrlID.Src.Interfaces
{
  public interface IServiceBase<T> where T : class
  {
    List<T> GetAll(int top = 0);
    T? Get(params object[] keys);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
  }
}


