using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Contracts;

public interface IPagosRepository : IRepository<Pago>, IReadRepository<Pago>
{
    Task<IReadOnlyList<Pago>> GetByClienteIdAsync(int id);
}
