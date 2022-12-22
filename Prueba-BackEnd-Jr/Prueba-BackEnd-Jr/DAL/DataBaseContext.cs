using Prueba_BackEnd_Jr.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba_BackEnd_Jr.DAL
{
    public class DataBaseContext : DbContext
    {
        //
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        //
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Ajuste> Ajustes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            modelBuilder.Entity<Cliente>().Property(p => p.MontoSolicitado).HasPrecision(28, 2);

            modelBuilder.Entity<Pago>().Property(p => p.MontoPagado).HasPrecision(28, 2);
            
            modelBuilder.Entity<Ajuste>().Property(p => p.MontoTotal).HasPrecision(28, 2);
            modelBuilder.Entity<Ajuste>().Property(p => p.Adeudo).HasPrecision(28, 2);
        }
    }
}
