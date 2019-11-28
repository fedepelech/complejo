using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComplejoSanBernardo {
    public class Reserva {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DepartamentoId {get;set;}
        public int ClienteId {get;set;}
        public int Seña { get; set; }
        public int Total { get; set; }
        public int Deposito { get; set; }
        public int DescuentoDepo { get; set; }
        public string Justificacion { get; set; }
        public int HsInicio = 14;
        public int HsFin = 10;
        public Departamento Departamento { get; set; }
        public Cliente Cliente { get; set; }
    }
}