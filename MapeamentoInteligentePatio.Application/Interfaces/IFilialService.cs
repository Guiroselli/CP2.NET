
using MapeamentoInteligentePatio.Application.DTOs;

namespace MapeamentoInteligentePatio.Application.Interfaces;

public interface IFilialService
{
    Task<IEnumerable<FilialDTO>> GetAllAsync();
    Task<FilialDTO> GetByIdAsync(int id);
    Task<FilialDTO> CreateAsync(FilialDTO filial);
}
