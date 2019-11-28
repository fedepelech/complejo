using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace ComplejoSanBernardo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private IReserva reservaService;
        public ReservaController(IReserva reservaService)
        {
            this.reservaService = reservaService;
        }
        
        [HttpGet("TotalFechas")]
        public decimal Get([FromQuery(Name = "fechaInicio")] DateTime fechaInicio, [FromQuery(Name = "fechaFinal")] DateTime fechaFinal)
        {
            return reservaService.TotalGanadoFechas(fechaInicio, fechaFinal);
        }

        // GET api/reserva
        [HttpGet]
        public List<Reserva> GetAll()
        {
            return reservaService.GetAll();
        }

        // GET api/reserva/5
        [HttpGet("{id}")]
        public ActionResult<Reserva> Get(int id)
        {
            return reservaService.Get(id);    
        }

        // PUT api/reserva/
        [HttpPut]
        public void Put([FromBody] Reserva reserva)
        {
            reservaService.ActualizarDescuento(reserva);
        }
         
        // DELETE api/reserva/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            reservaService.Delete(id);
        }

        // POST api/reserva
        [HttpPost] 
        public Reserva Post(Reserva reserva)
        {
            return reservaService.CrearReserva(reserva);
        }

        //GET TotalGanadoxAlquiler
        [HttpGet("totalGanado")]
        public int TotalGanadoxAlquiler([FromBody] Reserva reserva)
        {
            return reservaService.TotalGanadoxAlquiler(reserva);
        }
        
    }
}