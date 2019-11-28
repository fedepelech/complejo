using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComplejoSanBernardo
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private IDepartamento departamentoService;
        public DepartamentoController(IDepartamento departamentoService)
        {
            this.departamentoService = departamentoService;
        }
        // GET api/departamento/5
        [HttpGet("{id}")]
        public ActionResult<Departamento> Get(int id)
        {
            return departamentoService.Get(id);
        }

        [HttpGet("ExtraerEnFechas")]
        public List<Departamento> GetDepto([FromQuery(Name = "fechaInicio")] DateTime fechaInicio, [FromQuery(Name = "fechaFinal")] DateTime fechaFinal)
        {
            return departamentoService.GetDisponibilidad(fechaInicio, fechaFinal);
        }

        [HttpGet("Dispo")]
        public bool GetDispo([FromQuery(Name = "id")]int id, [FromQuery(Name = "fechaInicio")] DateTime fechaInicio, [FromQuery(Name = "fechaFinal")] DateTime fechaFinal)
        {
            return departamentoService.estaDisponible(id, fechaInicio, fechaFinal);
        }

        // POST api/departamento
        [HttpPost]
        public void Post([FromBody] Departamento departamento)
        {
            departamentoService.Save(departamento);
        }

        // PUT api/departamento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Departamento departamento)
        {
            departamentoService.Save(departamento);
        }

        // DELETE api/departamento/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            departamentoService.Delete(id);
        }
    }
}
