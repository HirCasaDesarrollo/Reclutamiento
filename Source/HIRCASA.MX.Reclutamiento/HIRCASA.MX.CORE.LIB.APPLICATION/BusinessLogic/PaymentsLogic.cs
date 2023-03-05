// <copyright file="PaymentsLogic.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.APPLICATION.BusinessLogic
{
    using System.Net;
    using System.Threading.Tasks;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common.Const;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Clients;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Payment;
    using NLog.Config;

    /// <summary>
    /// Class that implements payments logic.
    /// </summary>
    public class PaymentsLogic : IPaymentsLogic
    {
        /// <summary>
        /// Clients unit instance.
        /// </summary>
        private readonly IPaymentsUnit paymentsUnit;

        private readonly IClientsUnit clientsUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsLogic"/> class.
        /// </summary>
        /// <param name="payments">payments instance.</param>
        public PaymentsLogic(IPaymentsUnit payments, IClientsUnit clientsUnit)
        {
            this.paymentsUnit = payments;
            this.clientsUnit = clientsUnit;
        }

        /// <summary>
        ///  Gets client´s FinishMount.
        /// </summary>
        /// <param name="idClient">client id.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<MethodResponse<bool>> GetFinishAmountAsync(int idClient)
        {
            var result = new MethodResponse<bool>();

            // obtiene el cliente al qu ese le actualizara la aprovacion
            var currentClient = await this.clientsUnit.GetClientAsync(idClient);

            // si el cliente no existe terminamos la ejecución indicando el error.
            if (currentClient is null)
            {
                result.Code = (int)HttpStatusCode.NoContent;
                result.Message = "El cliente indicado no existe";
                result.Result = false;
                return result;
            }

            // obtenemos el ajuste del cliente para realizar los calculos
            var clientAdjustment = await this.paymentsUnit.GetAdjustmentByclientIdAsync(idClient);

            if (clientAdjustment != null)
            {
                // calcula el adeudo del cliente y se guarda la actualización del ajuste
                clientAdjustment.Adeudo = clientAdjustment.MontoTotal - currentClient.MontoSolicitud;

                await this.paymentsUnit.AlterAdjustmentAsync(clientAdjustment);
            }
            else
            {
                result.Code = (int)HttpStatusCode.NoContent;
                result.Message = "El cliente indicado no tiene ajuste previo calculado, calcular primero el ajuste";
                result.Result = false;
                return result;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns></returns>
        public async Task<MethodResponse<bool>> UpdateAprovationStatus(int idClient)
        {
            var result = new MethodResponse<bool>();

            // obtiene el cliente al qu ese le actualizara la aprovacion
            var currentClient = await this.clientsUnit.GetClientAsync(idClient);

            // si el cliente no existe terminamos la ejecución indicando el error.
            if (currentClient is null)
            {
                result.Code = (int)HttpStatusCode.NoContent;
                result.Message = "El cliente indicado no existe";
                result.Result = false;
                return result;
            }

            // se calcula el estatus del cliente
            currentClient.Aprobacion = currentClient.Estatus == ClientStatus.Aware || currentClient.Estatus == ClientStatus.WithDebit;

            // se actualiza el cliente con el nuevo estatus
            await this.clientsUnit.UpdateClientAsync(currentClient);

            return result;
        }

        public async Task<MethodResponse<bool>> UpdateClientStatus(int idClient)
        {
            var result = new MethodResponse<bool>();

            if (await this.clientsUnit.GetClientAsync(idClient) is null)
            {
                result.Code = (int)HttpStatusCode.BadRequest;
                result.Message = "El cliente indicado no existe";

                return result;
            }

            // obtiene los pagos realizados por el cliente
            var clientPayments = await this.paymentsUnit.GetPaymentByIdClientAsync(idClient);

            // obtiene la suma de los pagos aplicados realizados por el cliente
            var clientsPaymentssum = clientPayments.Where(b => b.Aplicado).Sum(a => a.MontoPagado);

            // obtiene los ajustes realizaos al cliente
            var clientsTotal = await this.paymentsUnit.GetAdjustmentByclientIdAsync(idClient);

            // obtiene el total actual.
            var currentTotal = clientsTotal.MontoTotal - clientsPaymentssum;

            // asignacion de estatus al cliente
            string status = string.Empty;
            if (currentTotal == clientsPaymentssum)
            {
                status = ClientStatus.Aware;
            }

            if (clientsTotal.MontoTotal < clientsPaymentssum)
            {
                status = ClientStatus.WithDebit;
            }

            if (currentTotal == 0)
            {
                status = ClientStatus.Cancelation;
            }

            // si el estatus etsa dentro de los parametros se actualiza.
            if (!string.IsNullOrEmpty(status))
            {
                await this.clientsUnit.UpdateClientStatusAsync(idClient, status);
                result.Message = "el estatus fue modificado";
                result.Code = (int)HttpStatusCode.OK;
            }
            else
            {
                result.Message = "el estatus no pudo ser modificado ya que no cumplia con las caracteristicas para modificarse.";
                result.Code = (int)HttpStatusCode.NotModified;
                result.Result = false;
            }

            return result;
        }

        public async Task<MethodResponse<bool>> UpdateTotalAmountAsync(int idClient)
        {
            var result = new MethodResponse<bool>();

            if (await this.clientsUnit.GetClientAsync(idClient) is null)
            {
                result.Code = (int)HttpStatusCode.BadRequest;
                result.Message = "El cliente indicado no existe";

                return result;
            }

            // obtiene los pagos realizados por el cliente
            var clientPayments = await this.paymentsUnit.GetPaymentByIdClientAsync(idClient);

            // obtiene la suma de los pagos aplicados realizados por el cliente
            var clientsPaymentSum = clientPayments.Where(b => b.Aplicado).Sum(a => a.MontoPagado);

            // obtenemos el ajuste del cliente
            var adjustment = await this.paymentsUnit.GetAdjustmentByclientIdAsync(idClient);

            // si el ajuste ya existe se actualiza el monto total
            if (adjustment is not null)
            {
                adjustment.MontoTotal = clientsPaymentSum;
                await this.paymentsUnit.AlterAdjustmentAsync(adjustment);

                result.Code = (int)HttpStatusCode.Accepted;
                result.Message = "El monto total del cliente se ha actualizado";
            }
            else
            {
                // si no existe creamos un nuevo ajuste para el cliente
                var newAdjustment = new Ajuste { ClienteId = idClient, MontoTotal = clientsPaymentSum };
                await this.paymentsUnit.CreateAdjustmentAsync(newAdjustment);

                result.Code = (int)HttpStatusCode.OK;
                result.Message = "Se ha creado un nuevo ajuste para el cliente.";
            }

            return result;
        }
    }
}
