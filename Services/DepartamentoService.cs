using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplejoSanBernardo;

namespace ComplejoSanBernardo
{
  public class DepartamentoService : IDepartamento
  {
    private readonly MyDbContext db;
    public DepartamentoService (MyDbContext db)
    {
      this.db = db;
    }

    public Departamento Get(int id)
    {
      return db.Departamento.ToList().Find(d => d.Id == id);
    }

    public IEnumerable<Departamento> GetAll()
    {
      return db.Departamento.OrderBy(d => d.Id);
    }
    public void Delete(int id)
    {
      var depto = db.Departamento.SingleOrDefault(m=> m.Id == id);
      if(depto != null)
      {
        db.Departamento.Remove(depto);
      }
      db.SaveChanges();
    }

    public void Save(Departamento departamento)
    {
      db.Departamento.Add(departamento);
      db.SaveChanges();
    }

    public List<Departamento> GetDisponibilidad(DateTime fechaInicio, DateTime fechaFinal)
    {
      List<Departamento> ListaDisponibles = new List<Departamento>();
      ListaDisponibles = db.Departamento.ToList(); 
      // Tengo que filtar las reservas de modo que la fecha fin de la lista sea menor fecha de inicio de parametro
      // Lista reservas: 20/10; 21/10; 22/10
      // Parametro 20/10
      List<Reserva> reservasPorFecha = db.Reserva.ToList().FindAll(m=>fechaInicio <= m.FechaFin && fechaFinal >= m.FechaInicio);
      foreach (var item in reservasPorFecha)
      {
          if(ListaDisponibles.Exists(m=>m.Id == item.Departamento.Id))
          {
            ListaDisponibles.RemoveAt(ListaDisponibles.FindIndex(m=>m.Id == item.Departamento.Id));
          }
      }
      return ListaDisponibles;
    }

    public bool estaDisponible(int id, DateTime fechaInicio, DateTime fechaFinal)
    {
      List<Departamento> ListaDepartamento = GetDisponibilidad(fechaInicio, fechaFinal);
      bool option = false;
      foreach (var departamento in ListaDepartamento)
      {
          if(departamento.Id == id)
          {
            option = true;
          }
      }
      return option;
    }
    
  }
}