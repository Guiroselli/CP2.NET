
using Microsoft.EntityFrameworkCore;
using MapeamentoInteligentePatio.Domain.Entities;

namespace MapeamentoInteligentePatio.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Moto> Motos => Set<Moto>();
        public DbSet<Filial> Filiais => Set<Filial>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moto>().ToTable("MOTOS");
            modelBuilder.Entity<Filial>().ToTable("FILIAIS");
        }
    }
}
