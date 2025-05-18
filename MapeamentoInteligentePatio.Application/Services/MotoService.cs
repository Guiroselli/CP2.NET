
using Microsoft.EntityFrameworkCore;
using MapeamentoInteligentePatio.Application.DTOs;
using MapeamentoInteligentePatio.Application.Interfaces;
using MapeamentoInteligentePatio.Domain.Entities;
using MapeamentoInteligentePatio.Infrastructure.Data;
using AutoMapper;

namespace MapeamentoInteligentePatio.Application.Services
{
    public class MotoService : IMotoService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MotoService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MotoDTO>> GetAllAsync()
        {
            var motos = await _context.Motos.ToListAsync();
            return _mapper.Map<List<MotoDTO>>(motos);
        }

        public async Task<MotoDTO> GetByIdAsync(int id)
        {
            var moto = await _context.Motos.FindAsync(id);
            return _mapper.Map<MotoDTO>(moto);
        }

        public async Task<MotoDTO> CreateAsync(MotoDTO moto)
        {
            var entity = _mapper.Map<Moto>(moto);
            _context.Motos.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<MotoDTO>(entity);
        }

        public async Task UpdateAsync(int id, MotoDTO moto)
        {
            var entity = await _context.Motos.FindAsync(id);
            if (entity == null) return;
            _mapper.Map(moto, entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Motos.FindAsync(id);
            if (entity == null) return;
            _context.Motos.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
