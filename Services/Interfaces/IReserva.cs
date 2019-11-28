using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoSanBernardo
{
    public interface IReserva
    {
        Reserva Get(int id);
        List<Reserva> GetAll();
        void Delete(int id);
        void ActualizarDescuento(Reserva reserva);
        Reserva CrearReserva(Reserva reserva);
        int TotalGanadoxAlquiler(Reserva reserva);
        int TotalGanadoFechas(DateTime fechaInicio, DateTime fechaFinal);
    }

}
