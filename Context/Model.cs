using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComplejoSanBernardo
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
            
        }
        public DbSet<Departamento> Departamento {get;set;}
        public DbSet<Cliente> Cliente {get;set;}
        public DbSet<Reserva> Reserva {get;set;}
    }
}