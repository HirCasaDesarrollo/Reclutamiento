using HIRCasa.Reclutamiento.Core.Context;
using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Repositories;

public class PagosRepository : BaseRepository<Pago>, IPagosRepository
{
    private readonly HIRCasaContext _dbContext;
    private readonly IApplicationReadDbConnection _readDbConnection;
    private readonly IApplicationWriteDbConnection _writeDbConnection;

    public PagosRepository(HIRCasaContext dbContext, IApplicationReadDbConnection readDbConnection, IApplicationWriteDbConnection writeDbConnection) :
        base(dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _readDbConnection = readDbConnection ?? throw new ArgumentNullException(nameof(readDbConnection));
        _writeDbConnection = writeDbConnection ?? throw new ArgumentNullException(nameof(writeDbConnection));
    }

    public async Task<IReadOnlyList<Pago>> GetByClienteIdAsync(int id)
    {
        return await _readDbConnection.QueryAsync<Pago>(
            sql: "SELECT * FROM Pagos WHERE clienteid = @id",
            param: new { id });
    }
}
