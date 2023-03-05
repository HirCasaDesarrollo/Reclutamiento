namespace HIRCASA.MX.WEB.API.Credits.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Controller base
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        private ISender mediator;

        /// <summary>
        /// Mediator
        /// </summary>
        protected ISender Mediator => this.mediator ??= this.HttpContext.RequestServices.GetService<ISender>();
    }
}
