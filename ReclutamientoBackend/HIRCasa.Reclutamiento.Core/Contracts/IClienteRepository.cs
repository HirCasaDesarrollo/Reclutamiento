using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Contracts;

public interface IClienteRepository : IRepository<Cliente>, IReadRepository<Cliente>
{
}
