using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComplejoSanBernardo;
using Microsoft.Extensions.DependencyInjection;

namespace ComplejoSanBernardo 
{
    public class ReservaService : IReserva 
    {
        private readonly MyDbContext db;
        public ReservaService (MyDbContext db)
        {
            this.db = db;
        }
        public Reserva Get (int id) 
        {
            return db.Reserva.FirstOrDefault (s => s.Id == id);
        }
        public List<Reserva> GetAll () 
        {
            return db.Reserva.ToList();
        }
        public void Delete(int id)
        {
          var rsv = db.Reserva.SingleOrDefault(m=> m.Id == id);
          if(rsv != null)
          {
            db.Reserva.Remove(rsv);
          }
          db.SaveChanges();
        }
        public void ActualizarDescuento(Reserva reserva)
        {
            var ReservaActual = db.Reserva.FirstOrDefault(R => R.Id == reserva.Id);
            if (ReservaActual != null)
            {
              ReservaActual.Justificacion = reserva.Justificacion;
              ReservaActual.DescuentoDepo = reserva.DescuentoDepo;
            }
        }
        public Reserva CrearReserva(Reserva reserva)
        {
            DepartamentoService depto1 = new DepartamentoService(db);
            int disp = depto1.GetDisponibilidad(reserva.FechaInicio, reserva.FechaFin).Count();
            if (disp >= 1)
            {
                reserva.Cliente = db.Cliente.FirstOrDefault(r=>r.Id == reserva.ClienteId);
                db.Reserva.Add(reserva);
                db.SaveChanges();
            }
            return reserva; 
        }
        public int TotalGanadoFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            int TotalDinero = 0;
            List<Reserva> reservasPorFecha = db.Reserva.ToList().FindAll(m=>fechaInicio <= m.FechaFin && fechaFinal >= m.FechaInicio);
            foreach (var item in reservasPorFecha)
            {
                TotalDinero += this.TotalGanadoxAlquiler(item);
            }
            return TotalDinero;
        }
        public int TotalGanadoxAlquiler(Reserva reserva)
        {
            var totalGanadoxAlquiler = reserva.Total + reserva.DescuentoDepo;
            return totalGanadoxAlquiler;
        }
    }
}