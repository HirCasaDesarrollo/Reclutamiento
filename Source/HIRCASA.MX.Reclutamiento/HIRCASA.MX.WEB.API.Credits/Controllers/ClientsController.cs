namespace HIRCASA.MX.WEB.API.Credits.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Clients controller.
    /// </summary>
    public class ClientsController : ApiControllerBase
    {
        [HttpPost]
        [Route("ErraseEmptyEspaces")]
        public async Task<IActionResult> ErraseEmptyEspaces(int clientId)
        {
            var command = new CORE.LIB.APPLICATION.Commands.Clients.ErraseEmptyEspacesCommand();
            command.ClientId = clientId;

            var Response = await Mediator.Send(command);

            if (Response.Code != 200)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Response);
            }

            return StatusCode(StatusCodes.Status200OK, Response.Result);
        }
    }
}
