using SistemaDeVeiculos.Enums;

namespace SistemaDeVeiculos.Models
{

    public class VeiculoModel
    {
        public int Id { get; set; }
        public MarcasVeiculos Marca { get; set; }
        public ModelosVeiculos Modelo { get; set; }
        public int AnoFab { get; set; }
        public decimal Km { get; set; }
        public string? ChassiNum { get; set; }
    }
}