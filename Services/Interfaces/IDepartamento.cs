using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoSanBernardo
{
     public interface IDepartamento
    {
        void Save(Departamento departamento);
        void Delete(int id);
        IEnumerable<Departamento> GetAll();
        Departamento Get (int id);
        List<Departamento> GetDisponibilidad(DateTime fechaInicio, DateTime fechaFinal);
        bool estaDisponible(int id, DateTime fechaInicio, DateTime fechaFinal);
    }
}
