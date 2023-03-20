using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Contracts;

public interface IAjustesRepository : IRepository<Ajuste>, IReadRepository<Ajuste>
{
    Task<IReadOnlyList<Ajuste>> GetByClienteIdAsync(int id);
}
