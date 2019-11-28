using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplejoSanBernardo;

namespace ComplejoSanBernardo
{
  public class ClienteService : ICliente
  {
        private readonly MyDbContext db;
        public ClienteService (MyDbContext db)
        {
          this.db = db;
        }

        public Cliente Get(int id)
        {
          return db.Cliente.FirstOrDefault(st => st.Id == id);
        }

        public void Save(int id, Cliente cliente)
        {
          var clt = db.Cliente.SingleOrDefault(m=> m.Id == id);
          if(clt != null)
          {
            db.Cliente.Remove(clt);
          }
          db.Cliente.Add(cliente);
          db.SaveChanges();
        }

        public void Delete(int id)
        {
          var cliente = db.Cliente.SingleOrDefault(m=> m.Id == id);
          if(cliente != null)
          {
            db.Cliente.Remove(cliente);
          }
          db.SaveChanges();
        }
  }
}