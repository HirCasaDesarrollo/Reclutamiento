using HIRCasa.Reclutamiento.Core.Context;
using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HIRCasa.Reclutamiento.Core.Repositories;

public class AjustesRepository : BaseRepository<Ajuste>, IAjustesRepository
{
    private readonly HIRCasaContext _dbContext;
    private readonly IApplicationReadDbConnection _readDbConnection;
    private readonly IApplicationWriteDbConnection _writeDbConnection;

    public AjustesRepository(HIRCasaContext dbContext, IApplicationReadDbConnection readDbConnection, IApplicationWriteDbConnection writeDbConnection) :
        base(dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _readDbConnection = readDbConnection ?? throw new ArgumentNullException(nameof(readDbConnection));
        _writeDbConnection = writeDbConnection ?? throw new ArgumentNullException(nameof(writeDbConnection));
    }

    public async Task<IReadOnlyList<Ajuste>> GetByClienteIdAsync(int id)
    {
        return await _readDbConnection.QueryAsync<Ajuste>(
            sql: "SELECT * FROM Ajustes WHERE clienteid = @id",
            param: new { id });
    }
}
