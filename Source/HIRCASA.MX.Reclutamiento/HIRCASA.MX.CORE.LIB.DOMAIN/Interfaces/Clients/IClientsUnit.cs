// <copyright file="IClientsUnit.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients
{
    /// <summary>
    /// Interface for Clients unit of work.
    /// </summary>
    public interface IClientsUnit
    {
        /// <summary>
        /// Create a client in DB.
        /// </summary>
        /// <param name="client">Client entity.</param>
        /// <returns>Task. </returns>
        Task CreateClientAsync(Cliente client);

        /// <summary>
        /// Updates a client in BD.
        /// </summary>
        /// <param name="client">client entity.</param>
        /// <returns>Task.</returns>
        Task UpdateClientAsync(Cliente client);

        /// <summary>
        /// Gets a especified client by Id
        /// </summary>
        /// <param name="id">Id client</param>
        /// <returns>Especified client</returns>
        Task<Cliente> GetClientAsync(int id);

        /// <summary>
        /// Gets a especified client by Id.
        /// </summary>
        /// <param name="id">Id client.</param>
        /// <returns>Especified client.</returns>
        Task<IEnumerable<Cliente>> GetClients();

        /// <summary>
        /// Update the client estatus.
        /// </summary>
        /// <param name="idClient">id client.</param>
        /// <param name="status">new clients status</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task UpdateClientStatusAsync(int idClient, string status);
    }
}
