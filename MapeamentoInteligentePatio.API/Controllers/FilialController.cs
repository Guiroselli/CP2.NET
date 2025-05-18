
using Microsoft.AspNetCore.Mvc;
using MapeamentoInteligentePatio.Application.DTOs;
using MapeamentoInteligentePatio.Application.Interfaces;

namespace MapeamentoInteligentePatio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilialController : ControllerBase
{
    private readonly IFilialService _filialService;

    public FilialController(IFilialService filialService)
    {
        _filialService = filialService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var filiais = await _filialService.GetAllAsync();
        return Ok(filiais);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var filial = await _filialService.GetByIdAsync(id);
        return filial == null ? NotFound() : Ok(filial);
    }

    [HttpPost]
    public async Task<IActionResult> Create(FilialDTO filial)
    {
        var created = await _filialService.CreateAsync(filial);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
}
