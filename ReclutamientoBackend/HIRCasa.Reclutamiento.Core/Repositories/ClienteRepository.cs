using HIRCasa.Reclutamiento.Core.Context;
using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Repositories;

public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
{
    private readonly HIRCasaContext _dbContext;
    private readonly IApplicationReadDbConnection _readDbConnection;
    private readonly IApplicationWriteDbConnection _writeDbConnection;

    public ClienteRepository(HIRCasaContext dbContext, IApplicationReadDbConnection readDbConnection, IApplicationWriteDbConnection writeDbConnection) :
        base(dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _readDbConnection = readDbConnection ?? throw new ArgumentNullException(nameof(readDbConnection));
        _writeDbConnection = writeDbConnection ?? throw new ArgumentNullException(nameof(writeDbConnection));
    }
}
