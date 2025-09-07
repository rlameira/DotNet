using MonitorCtrlID.Src.Data;

namespace MonitorCtrlID.Src.Interfaces
{
  public interface IServiceBase<T> where T : class
  {
    List<T> GetAll(int top = 0);
    T? Get(params object[] keys);
    void Add(T entity, bool saveChanges = true);
    void Update(T entity, bool saveChanges = true);
    void Delete(T entity, bool saveChanges = true);
  }
}


