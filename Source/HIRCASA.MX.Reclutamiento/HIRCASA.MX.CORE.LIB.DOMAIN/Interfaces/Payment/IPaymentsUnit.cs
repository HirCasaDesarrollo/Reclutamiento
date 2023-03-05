// <copyright file="IPaymentsUnit.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Payment
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;

    /// <summary>
    /// Payment unit interface.
    /// </summary>
    public interface IPaymentsUnit
    {
        #region Payments

        /// <summary>
        /// Create client´s payment.
        /// </summary>
        /// <param name="payment">payment id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<bool> CreatePaymentAsync(Pago payment);

        /// <summary>
        /// Alter client´s payment.
        /// </summary>
        /// <param name="payment">payment to alter.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<bool> AlterPaymentAsync(Pago payment);

        /// <summary>
        /// Gets payment by id or All payments by idclient.
        /// </summary>
        /// <param name="Idpayment">id payment.</param>
        /// <param name="idclient">id client.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<Pago> GetPaymentByIdAsync(int Idpayment);

        /// <summary>
        /// Gets payment by id or All payments by idclient.
        /// </summary>
        /// <param name="Idpayment">id payment.</param>
        /// <param name="idclient">id client.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<List<Pago>> GetPaymentByIdClientAsync(int idclient);

        /// <summary>
        /// Gets all payments in DB.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<List<Pago>> GetPaymentsListAsync();
        #endregion

        #region Adjusments

        /// <summary>
        /// Create a payment adjustment.
        /// </summary>
        /// <param name="adjustment">adjustment to create.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<bool> CreateAdjustmentAsync(Ajuste adjustment);

        /// <summary>
        /// Alter Client´s payment adjustment.
        /// </summary>
        /// <param name="adjustment">adjustment to alter.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<bool> AlterAdjustmentAsync(Ajuste adjustment);

        /// <summary>
        /// Get a client´s payment adjustment.
        /// </summary>
        /// <param name="idclient">Client id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<Ajuste> GetAdjustmentByclientIdAsync(int idclient);

        /// <summary>
        /// Get all payment adjustment in DB
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task<List<Ajuste>> GetAdjustmentListAsync();

        #endregion
    }
}
