using Microsoft.EntityFrameworkCore;
using SistemaDeVeiculos.Models;

namespace SistemaDeVeiculos.Data
{
    public class SistemaDeVeiculosDBContex : DbContext
    {
        public SistemaDeVeiculosDBContex(DbContextOptions<SistemaDeVeiculosDBContex> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<VeiculoModel> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
