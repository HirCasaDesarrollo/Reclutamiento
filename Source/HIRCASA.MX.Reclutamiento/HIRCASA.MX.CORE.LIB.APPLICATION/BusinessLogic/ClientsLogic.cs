// <copyright file="ClientsLogic.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>
namespace HIRCASA.MX.CORE.LIB.APPLICATION.BusinessLogic
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients;

    /// <summary>
    /// Implements the clients Bussines Logic.
    /// </summary>
    public class ClientsLogic : IClientsLogic
    {
        private readonly IClientsUnit clientsUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsLogic"/> class.
        /// </summary>
        /// <param name="clients">clientsUnit interface.</param>
        public ClientsLogic(IClientsUnit clients)
        {
            this.clientsUnit = clients;
        }

        /// <summary>
        /// Correct the name clients table.
        /// </summary>
        /// <returns> <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<int> ErraseEmptyEspaces()
        {
            // obtenemos los registros existentes en la Bd
            var clientsToCorrectName = await this.clientsUnit.GetClients();

            // itera los registros y les identa los espacios
            foreach (var client in clientsToCorrectName)
            {
                // realizamo sun trim para identar los espacios extra
                client.Nombre = client.Nombre.Trim();

                // se actualiza el registro en BD
                await this.clientsUnit.UpdateClientAsync(client);
            }

            return clientsToCorrectName.Count();
        }

        /// <summary>
        /// Correct the name clients table.
        /// </summary>
        /// <param name="clientId">client id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<bool> ErraseEmptyEspaces(int clientId)
        {
            // obtenemos los registros existentes en la Bd
            var clientToCorrectName = await this.clientsUnit.GetClientAsync(clientId);

            if (clientToCorrectName is not null)
            {
                // realizamo sun trim para identar los espacios extra
                clientToCorrectName.Nombre = clientToCorrectName.Nombre.Trim();

                // se actualiza el registro en BD
                await this.clientsUnit.UpdateClientAsync(clientToCorrectName);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
