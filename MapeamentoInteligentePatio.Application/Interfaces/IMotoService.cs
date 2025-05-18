
using MapeamentoInteligentePatio.Application.DTOs;

namespace MapeamentoInteligentePatio.Application.Interfaces;

public interface IMotoService
{
    Task<IEnumerable<MotoDTO>> GetAllAsync();
    Task<MotoDTO> GetByIdAsync(int id);
    Task<MotoDTO> CreateAsync(MotoDTO moto);
    Task UpdateAsync(int id, MotoDTO moto);
    Task DeleteAsync(int id);
}
