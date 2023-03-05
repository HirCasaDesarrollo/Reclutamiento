// <copyright file="ErraseEmptyEspacesCommand.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.APPLICATION.Commands.Clients
{
    using System.Net;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients;
    using MediatR;

    /// <summary>
    /// Handler for Command logic dinitions.
    /// </summary>
    public class ErraseEmptyEspacesCommandHandler : IRequestHandler<ErraseEmptyEspacesCommand, MethodResponse<bool>>
    {
        private readonly IClientsLogic logic;


        /// <summary>
        /// Initializes a new instance of the <see cref="ErraseEmptyEspacesCommandHandler"/> class.
        /// </summary>
        /// <param name="clients">Clients Logic</param>
        public ErraseEmptyEspacesCommandHandler(IClientsLogic clients)
        {
            this.logic = clients;
        }

        /// <summary>
        /// Clients command Handler.
        /// </summary>
        /// <param name="request">reques.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>method response.</returns>
        public async Task<MethodResponse<bool>> Handle(ErraseEmptyEspacesCommand request, CancellationToken cancellationToken)
        {
            var response = new MethodResponse<bool>();

            if (request.ClientId != 0)
            {
                var resp = await this.logic.ErraseEmptyEspaces(request.ClientId);
                response.Code = resp ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotModified;
                response.Result = resp;
                response.Message = resp ? "cliente modificado correctamente" : "No se pudo modificar el cliente indicado.";
                return response;
            }

            // se ejecuta el metodo para correir los clientes.
            var clientsCorrected = await this.logic.ErraseEmptyEspaces();

            // se valida si existieron modificaciones en la BD.
            var modified = clientsCorrected > 0;

            // creamos la respuesta deacuerdo a modified
            response.Code = modified ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotModified;
            response.Message = modified ? $"Se validaron {clientsCorrected} clientes y se identó el espaciado" : "No se realizaron modificacion en los nombres d elos clientes.";
            response.Result = modified;

            return response;
        }
    }
}
