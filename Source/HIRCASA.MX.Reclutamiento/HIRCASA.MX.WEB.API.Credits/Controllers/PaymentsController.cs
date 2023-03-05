namespace HIRCASA.MX.WEB.API.Credits.Controllers
{
    using HIRCASA.MX.CORE.LIB.APPLICATION.Commands.Payments.Commands;
    using Microsoft.AspNetCore.Mvc;

    public class PaymentsController : ApiControllerBase
    {
        [HttpPost]
        [Route("Payments")]
        public async Task<IActionResult> Payments(int clientId,string actionType)
        {
            var command = new PaymentsCommand();

            var Response = await Mediator.Send(command);

            if (Response.Code != 200)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Response);
            }

            return StatusCode(StatusCodes.Status200OK, Response.Result);
        }
    }
}
