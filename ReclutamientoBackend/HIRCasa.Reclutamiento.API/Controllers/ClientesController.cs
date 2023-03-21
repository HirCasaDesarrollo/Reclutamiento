using HIRCasa.Reclutamiento.Core.Contracts;
using HIRCasa.Reclutamiento.Core.Repositories;
using HIRCasa.Reclutamiento.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace HIRCasa.Reclutamiento.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _repository;

    public ClientesController(IClienteRepository repository) => _repository = repository;

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
            return NotFound($"El cliente con Id {id} no existe.");

        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<Cliente>> AddCliente([FromForm] Cliente entity)
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

    [HttpPatch("{id:int}")]
    public async Task<IActionResult> UpdateCliente(int id, [FromBody] JsonPatchDocument<Cliente> clienteDoc)
    {
        if (clienteDoc is null)
            return BadRequest(ModelState);

        var existEntity = await _repository.GetByIdAsync(id);
        if (existEntity is null)
            return NotFound($"El cliente con Id {id} no existe.");

        clienteDoc.ApplyTo(existEntity, ModelState);

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
            return NotFound($"El cliente con Id {id} no existe.");

        _repository.Delete(entity);

        var result = await _repository.UnitOfWork.SaveChangesAsync();
        if (result <= 0)
            return BadRequest();

        return NoContent();
    }
}