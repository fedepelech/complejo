using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace ComplejoSanBernardo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ICliente clienteService;

        public ClienteController(ICliente clienteService)
        {
            this.clienteService = clienteService;
        }
        
        // GET api/cliente/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            return clienteService.Get(id);
        }

        // POST api/cliente
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            clienteService.Save(cliente.Id ,cliente);
        }

        // PUT api/cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente cliente)
        {
            clienteService.Save(id, cliente);
        }

        // DELETE api/cliente/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clienteService.Delete(id);
        }
    }
}
