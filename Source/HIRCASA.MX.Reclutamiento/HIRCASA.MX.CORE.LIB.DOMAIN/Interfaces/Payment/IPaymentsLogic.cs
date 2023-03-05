// <copyright file="IPaymentsLogic.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>
namespace HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Payment
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;

    /// <summary>
    /// Payments logic interface.
    /// </summary>
    public interface IPaymentsLogic
    {
        public Task<MethodResponse<bool>> GetFinishAmountAsync(int idClient);

        public Task<MethodResponse<bool>> UpdateAprovationStatus(int idClient);

        public Task<MethodResponse<bool>> UpdateClientStatus(int idClient);

        public Task<MethodResponse<bool>> UpdateTotalAmountAsync(int idClient);
    }
}