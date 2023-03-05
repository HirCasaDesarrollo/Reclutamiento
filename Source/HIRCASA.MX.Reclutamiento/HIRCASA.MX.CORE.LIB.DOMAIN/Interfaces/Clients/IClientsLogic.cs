namespace HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients
{
    public interface IClientsLogic
    {
        /// <summary>
        /// Correct the name clients table.
        /// </summary>
        /// <returns> <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<int> ErraseEmptyEspaces();

        /// <summary>
        /// Correct the name clients table.
        /// </summary>
        /// <param name="clientId">client id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<bool> ErraseEmptyEspaces(int clientId);
    }
}
