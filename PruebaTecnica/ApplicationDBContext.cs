using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=HirCasa;Integrated Security=True;");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Ajuste> Ajustes { get; set; }

    }
}
