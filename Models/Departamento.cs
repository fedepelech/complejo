using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComplejoSanBernardo
{
    public class Departamento
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public ICollection<Reserva> Reservas {get;set;}
    }
}
