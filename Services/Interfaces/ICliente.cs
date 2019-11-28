using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoSanBernardo
{
    public interface ICliente
    {
        Cliente Get(int id);
        void Save(int id, Cliente cliente);   
        void Delete (int id);
    }
}