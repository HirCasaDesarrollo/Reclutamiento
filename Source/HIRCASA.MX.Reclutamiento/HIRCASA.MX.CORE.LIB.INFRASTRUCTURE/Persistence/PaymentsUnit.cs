// <copyright file="PaymentsUnit.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.INFRASTRUCTURE.Persistence
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Payment;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging.Abstractions;
    using NLog.Fluent;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// Payments unit class.
    /// </summary>
    public class PaymentsUnit : IPaymentsUnit
    {
        /// <summary>
        /// Context propertie.
        /// </summary>
        private readonly AppDataContext context;

        #region Payments

        /// <summary>
        /// Create client´s payment.
        /// </summary>
        /// <param name="payment">payment id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<bool> CreatePaymentAsync(Pago payment)
        {
            // se agrega a la tabla de pagos
            await this.context.Pagos.AddAsync(payment);
            var result = await context.SaveChangesAsync();

            // despues de guardar cambios se obtiene el id para registarlo en el log
            var id = this.context.Pagos.Last().PagoId;

            Log.Info($"Se creo un nuevo pago con id: {id}");

            return result > 0;
        }

        /// <summary>
        /// Alter client´s payment.
        /// </summary>
        /// <param name="payment">payment to alter.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<bool> AlterPaymentAsync(Pago payment)
        {
            this.context.Pagos.Update(payment);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// Gets payment by id or All payments by idclient.
        /// </summary>
        /// <param name="Idpayment">id payment.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<Pago> GetPaymentByIdAsync(int Idpayment)
        {
            return await this.context.Pagos.FirstOrDefaultAsync(a => a.PagoId == Idpayment);
        }

        /// <summary>
        /// Gets payment by id or All payments by idclient.
        /// </summary>
        /// <param name="Idpayment">id payment.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<List<Pago>> GetPaymentByIdClientAsync(int idclient)
        {
            return await this.context.Pagos.Where(a => a.ClienteId == idclient).ToListAsync();
        }

        /// <summary>
        /// Gets all payments in DB.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<List<Pago>> GetPaymentsListAsync()
        {
            return await this.context.Pagos.ToListAsync();
        }
        #endregion

        #region Adjusments

        /// <summary>
        /// Create a payment adjustment.
        /// </summary>
        /// <param name="adjustment">adjustment to create.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<bool> CreateAdjustmentAsync(Ajuste adjustment)
        {
            // se agrega a la tabla de pagos
            await this.context.Ajustes.AddAsync(adjustment);
            var result = await this.context.SaveChangesAsync();

            // despues de guardar cambios se obtiene el id para registarlo en el log
            var id = this.context.Ajustes.Last();

            Log.Info($"Se creo un nuevo pago con id: {id.AjusteId} para el cliente con id {id.ClienteId}");

            return result > 0;
        }

        /// <summary>
        /// Alter Client´s payment adjustment.
        /// </summary>
        /// <param name="adjustment">adjustment to alter.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<bool> AlterAdjustmentAsync(Ajuste adjustment)
        {
            this.context.Ajustes.Update(adjustment);
            var result = await this.context.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// Get a client´s payment adjustment.
        /// </summary>
        /// <param name="IdAdjustment"></param>
        /// <param name="idclient"></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<Ajuste> GetAdjustmentAsync(int IdAdjustment)
        {
            return await this.context.Ajustes.FirstOrDefaultAsync(a => a.AjusteId == IdAdjustment);
        }

        /// <summary>
        /// Get a client´s payment adjustment.
        /// </summary>
        /// <param name="idclient"></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<Ajuste> GetAdjustmentByclientIdAsync(int idclient)
        {
            return await this.context.Ajustes.FirstOrDefaultAsync(a => a.ClienteId == idclient);
        }

        /// <summary>
        /// Get all payment adjustment in DB.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<List<Ajuste>> GetAdjustmentListAsync()
        {
            return await this.context.Ajustes.ToListAsync();
        }
        #endregion
    }
}
