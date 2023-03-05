namespace HIRCASA.MX.CORE.LIB.APPLICATION.Commands.Payments.Commands
{
    using HIRCASA.MX.CORE.LIB.DOMAIN.Common;
    using MediatR;

    public class PaymentsCommand : IRequest<MethodResponse<bool>>
    {
        public string ActionType { get; set; }
        public int ClientId { get; set; }
    }
}
