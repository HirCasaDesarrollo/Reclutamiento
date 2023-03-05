// <copyright file="ErraseEmptyEspacesCommand.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.APPLICATION.Commands.Clients
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using MediatR;

    /// <summary>
    /// Command logic dinitions.
    /// </summary>
    public class ErraseEmptyEspacesCommand : IRequest<MethodResponse<bool>>
    {
        /// <summary>
        /// IdClient.
        /// </summary>
        public int ClientId { get; set; }
    }
}
