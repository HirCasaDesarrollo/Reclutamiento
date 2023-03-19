using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Core.Repositories;
using HIRCasa.Reclutamiento.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace HIRCasa.Reclutamiento.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReclutamientoController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        public ReclutamientoController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<Cliente> Get()
        {
            var results = _repository.GetAll();

            return Ok(results);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity is null)
                return NotFound($"El cliente con Id = {id} no existe.");

            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> InsertarCliente([FromForm] Cliente entity)
        {
            if (entity is null)
                return BadRequest(ModelState);

            var isValid = TryValidateModel(entity);
            if (!isValid)
                return BadRequest(ModelState);

            _repository.Add(entity);

            var result = await _repository.UnitOfWork.SaveChangesAsync();
            if (result <= 0)
                return BadRequest("Tu cliente no fue guardado.");

            return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
        }

    }
}