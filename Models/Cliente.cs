using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ComplejoSanBernardo
{
    public class Cliente
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public int Tel {get;set;}
        public ICollection<Reserva> Reservas {get;set;}
    }
}