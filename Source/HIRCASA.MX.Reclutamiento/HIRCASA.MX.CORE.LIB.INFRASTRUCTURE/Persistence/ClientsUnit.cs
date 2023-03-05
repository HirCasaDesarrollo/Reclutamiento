// <copyright file="ClientsUnit.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.INFRASTRUCTURE.Persistence
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Unit of work for clients.
    /// </summary>
    public class ClientsUnit : IClientsUnit
    {
        /// <summary>
        /// Clients Context propertie.
        /// </summary>
        private readonly AppDataContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistinguishedCustomerUnit"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ClientsUnit(AppDataContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Create a client in DB.
        /// </summary>
        /// <param name="client">Client entity.</param>
        /// <returns>Task. </returns>
        public async Task CreateClientAsync(Cliente client)
        {
            context.Add(client);

            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates a client in BD.
        /// </summary>
        /// <param name="client">client entity.</param>
        /// <returns>Task.</returns>
        public async Task UpdateClientAsync(Cliente client)
        {
            context.Update(client);
            await context.SaveChangesAsync();
        }

        public async Task UpdateClientStatusAsync(int idClient, string status)
        {
            var currentClient = await this.context.Clientes.FirstOrDefaultAsync(a => a.ClientId == idClient);
            if (currentClient is null)
            {
                return;
            }

            currentClient.Estatus = status;

            await this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets a especified client by Id
        /// </summary>
        /// <param name="id">Id client</param>
        /// <returns>Especified client</returns>
        public async Task<Cliente> GetClientAsync(int id)
        {
            return await context.Clientes.FirstOrDefaultAsync(a => a.ClientId == id);
        }

        /// <summary>
        /// Gets a especified client by Id.
        /// </summary>
        /// <param name="id">Id client.</param>
        /// <returns>Especified client.</returns>
        public async Task<IEnumerable<Cliente>> GetClients()
        {
            return await context.Clientes.ToListAsync();
        }
    }
}
