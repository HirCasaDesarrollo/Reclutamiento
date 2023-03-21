using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;
using System.Xml.Linq;

namespace HIRCasa.Reclutamiento.Core.Context
{
    public class HIRCasaContext : DbContext, IHIRCasaContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ajuste> Ajustes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public IDbConnection Connection => Database.GetDbConnection();
        public HIRCasaContext(DbContextOptions<HIRCasaContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

