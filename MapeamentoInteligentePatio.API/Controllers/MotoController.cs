
using Microsoft.AspNetCore.Mvc;
using MapeamentoInteligentePatio.Application.DTOs;
using MapeamentoInteligentePatio.Application.Interfaces;

namespace MapeamentoInteligentePatio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MotoController : ControllerBase
{
    private readonly IMotoService _motoService;

    public MotoController(IMotoService motoService)
    {
        _motoService = motoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var motos = await _motoService.GetAllAsync();
        return Ok(motos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var moto = await _motoService.GetByIdAsync(id);
        return moto == null ? NotFound() : Ok(moto);
    }

    [HttpPost]
    public async Task<IActionResult> Create(MotoDTO moto)
    {
        var created = await _motoService.CreateAsync(moto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, MotoDTO moto)
    {
        await _motoService.UpdateAsync(id, moto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _motoService.DeleteAsync(id);
        return NoContent();
    }
}
