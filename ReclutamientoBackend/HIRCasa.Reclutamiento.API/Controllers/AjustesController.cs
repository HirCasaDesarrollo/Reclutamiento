using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HIRCasa.Reclutamiento.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AjustesController : ControllerBase
{
    private readonly IAjustesRepository _repository;

    public AjustesController(IAjustesRepository repository) => _repository = repository;

    [HttpGet]
    public ActionResult<Ajuste> Get()
    {
        var results = _repository.GetAll();

        return Ok(results);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var entity = await _repository.GetByIdAsync(id);

        if (entity is null)
            return NotFound($"El ajuste con Id {id} no existe.");

        return Ok(entity);
    }

    [HttpGet("cliente/{id:int}")]
    public async Task<IActionResult> GetCliente(int id)
    {
        var entity = await _repository.GetByClienteIdAsync(id);

        if (entity is null)
            return NotFound($"El ajustes para el cliente con Id {id} no existe.");

        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<Ajuste>> AddCliente([FromForm] Ajuste entity)
    {
        if (entity is null)
            return BadRequest(ModelState);

        var isValid = TryValidateModel(entity);
        if (!isValid)
            return BadRequest(ModelState);

        _repository.Add(entity);

        var result = await _repository.UnitOfWork.SaveChangesAsync();
        if (result <= 0)
            return BadRequest("Tu ajuste no fue aplicado.");

        return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
    }

    [HttpPatch("{id:int}")]
    public async Task<IActionResult> UpdateAjuste(int id, [FromBody] JsonPatchDocument<Ajuste> ajusteDoc)
    {
        if (ajusteDoc is null)
            return BadRequest(ModelState);

        var existEntity = await _repository.GetByIdAsync(id);
        if (existEntity is null)
            return NotFound($"El ajustes con Id {id} no existe.");

        ajusteDoc.ApplyTo(existEntity, ModelState);

        var isValid = TryValidateModel(existEntity);
        if (!isValid)
            return BadRequest(ModelState);

        try
        {
            await _repository.UnitOfWork.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var entity = await _repository.GetByIdAsync(id);

        if (entity is null)
            return NotFound($"El ajuste con Id {id} no existe.");

        _repository.Delete(entity);

        var result = await _repository.UnitOfWork.SaveChangesAsync();
        if (result <= 0)
            return BadRequest();

        return NoContent();
    }
}
