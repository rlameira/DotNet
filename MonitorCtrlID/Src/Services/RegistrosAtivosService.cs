using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;
using MonitorCtrlID.Src.Middleware;

namespace MonitorCtrlID.Src.Services
{
  //public class RegistrosAtivosService(FBDBContexto contexto) : IServiceBase<Registrosativo>
  public class RegistrosAtivosService : IServiceBase<Registrosativo>
  {

    private readonly FBDBContexto contexto;

    public RegistrosAtivosService(FBDBContexto contexto)
    {
      this.contexto = contexto;
    }

    public Registrosativo GetUltimoByCodEquip(int codEquipamento)
    {
      var registroAtivo = contexto.Registrosativos
        .Where(r => r.Codequipamento == codEquipamento)
        .OrderByDescending(r => r.Dataehora)
        .FirstOrDefault();

      return registroAtivo;
    }
    public List<Registrosativo> GetAllByCodEquip(int codEquipamento, int top, string entradaSaida = "")
    {
      var query = contexto.Registrosativos
        .Where(r => (codEquipamento == 0 || r.Codequipamento == codEquipamento) && (entradaSaida == "" ||  r.EntradaSaida == entradaSaida))
        .OrderByDescending(r => r.Dataehora)
        .Take(top > 0 ? top : int.MaxValue);

      return [.. query];
    }

    
    List<Registrosativo> IServiceBase<Registrosativo>.GetAll(int top)
    {
      throw new NotImplementedException();
    }

    Registrosativo? IServiceBase<Registrosativo>.Get(params object[] keys)
    {
      throw new NotImplementedException();
    }

    //void IServiceBase<Registrosativo>.Add(Registrosativo entity)
    //{
    //  contexto.Registrosativos.Add(entity);
    //  contexto.SaveChanges();
    //}

    public async void Add(Registrosativo entity, bool saveChances = true)
    {
      try
      {
        var lstRegistros = contexto.Registrosativos
          .Where(r => r.Data == entity.Data
             && r.Hora == entity.Hora
             && r.Codequipamento == entity.Codequipamento
             && r.Codpessoavisitante == entity.Codpessoavisitante)
          .ToList();
        
        if (lstRegistros.Count == 0)
        {
          try
          {
            contexto.Registrosativos.Add(entity);
            Thread.Sleep(100);
            if (saveChances)
            {
              contexto.SaveChanges();
            }
          }
          catch (Exception ex)
          {
            await Logger.LogError(ex);
            // Aqui você captura qualquer problema (concorrência, conexão, etc.)
            //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
          }
        }
      }
      catch (Exception ex)
      {
        await Logger.LogError(ex);
        // Aqui você captura qualquer problema (concorrência, conexão, etc.)
        //Console.WriteLine($"Erro ao excluir operação: {ex.Message}");
      }
    }

    void IServiceBase<Registrosativo>.Update(Registrosativo entity, bool saveChanges = true)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Registrosativo>.Delete(Registrosativo entity, bool saveChanges = true)
    {
      throw new NotImplementedException();
    }

  }
}
