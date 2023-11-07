using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVeiculos.Models;

namespace SistemaDeVeiculos.Data.Map
{
    public class VeiculoMap : IEntityTypeConfiguration<VeiculoModel>
    {
        public void Configure(EntityTypeBuilder<VeiculoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Marca).IsRequired();
            builder.Property(x => x.Modelo).IsRequired();
            builder.Property(x => x.AnoFab).IsRequired();
            builder.Property(x => x.Km).IsRequired();
            builder.Property(x => x.ChassiNum).IsRequired().HasMaxLength(17);
        }
    }
}

