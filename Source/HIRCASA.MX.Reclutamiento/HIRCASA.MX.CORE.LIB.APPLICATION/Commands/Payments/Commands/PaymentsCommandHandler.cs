// <copyright file="PaymentsCommandHandler.cs" company="Hircasa - Prueba Reclutamiento">
// Copyright (c) Hircasa - Prueba Reclutamiento. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.APPLICATION.Commands.Payments.Commands
{
    using System.Net;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using HIRCASA.MX.CORE.LIB.DOMAIN.Interfaces.Payment;
    using MediatR;

    /// <summary>
    /// Command handler for payments.
    /// </summary>
    public class PaymentsCommandHandler : IRequestHandler<PaymentsCommand, MethodResponse<bool>>
    {
        private readonly IPaymentsLogic paymentsLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsCommandHandler"/> class.
        /// </summary>
        /// <param name="paymentsLogic">payment clients logic</param>
        public PaymentsCommandHandler(IPaymentsLogic paymentsLogic)
        {
            this.paymentsLogic = paymentsLogic;
        }

        /// <summary>
        /// Handler method.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <param name="cancellationToken">cancellation token </param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<MethodResponse<bool>> Handle(PaymentsCommand request, CancellationToken cancellationToken)
        {
            var response = new MethodResponse<bool>();
            if (request is null || string.IsNullOrEmpty(request.ActionType))
            {
                response.Code = (int)HttpStatusCode.BadRequest;
                response.Message = "El parametro request no puede ser nulo y El parametro ActionType no puede estar vacio";
                return response;
            }

            // ejecuta la cción dependiendo los parametros de entrada
            switch (request.ActionType)
            {
                case "actualizartotal":
                    response = await this.paymentsLogic.UpdateTotalAmountAsync(request.ClientId);
                    break;

                case "totalesReales":
                    response = await this.paymentsLogic.GetFinishAmountAsync(request.ClientId);
                    break;

                case "actualizarEstatus":
                    response = await this.paymentsLogic.UpdateClientStatus(request.ClientId);
                    break;

                case "actualizaaprobacion ":
                    response = await this.paymentsLogic.UpdateAprovationStatus(request.ClientId);
                    break;
            }

            return response;
        }
    }
}
