using HIRCasa.Reclutamiento.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HIRCasa.Reclutamiento.Core.Contracts;

public interface IHIRCasaContext : IUnitOfWork
{
    DbSet<Cliente> Clientes { get; }
    public IDbConnection Connection { get; }
}
