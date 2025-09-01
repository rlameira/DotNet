using Microsoft.EntityFrameworkCore;
using MonitorCtrlID.src.Models;
using MonitorCtrlID.Src.Data;
using MonitorCtrlID.Src.Interfaces;
using System.Windows.Forms;

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

    public void Add(Registrosativo entity)
    {
      var registros = contexto.Registrosativos
        .Where(r => r.Data == entity.Data
           && r.Hora == entity.Hora
           && r.Codequipamento == entity.Codequipamento
           && r.Codpessoavisitante == entity.Codpessoavisitante)
        .ToList();

      if (registros.Count == 0)
      {
        contexto.Registrosativos.Add(entity);
        contexto.SaveChanges();
      }
    }

    void IServiceBase<Registrosativo>.Update(Registrosativo entity)
    {
      throw new NotImplementedException();
    }

    void IServiceBase<Registrosativo>.Delete(Registrosativo entity)
    {
      throw new NotImplementedException();
    }

  }
}
