
using Microsoft.EntityFrameworkCore;
using MapeamentoInteligentePatio.Application.DTOs;
using MapeamentoInteligentePatio.Application.Interfaces;
using MapeamentoInteligentePatio.Domain.Entities;
using MapeamentoInteligentePatio.Infrastructure.Data;
using AutoMapper;

namespace MapeamentoInteligentePatio.Application.Services
{
    public class FilialService : IFilialService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FilialService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FilialDTO>> GetAllAsync()
        {
            var filiais = await _context.Filiais.ToListAsync();
            return _mapper.Map<List<FilialDTO>>(filiais);
        }

        public async Task<FilialDTO> GetByIdAsync(int id)
        {
            var filial = await _context.Filiais.FindAsync(id);
            return _mapper.Map<FilialDTO>(filial);
        }

        public async Task<FilialDTO> CreateAsync(FilialDTO filial)
        {
            var entity = _mapper.Map<Filial>(filial);
            _context.Filiais.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<FilialDTO>(entity);
        }
    }
}
