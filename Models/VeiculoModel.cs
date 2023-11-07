namespace SistemaDeVeiculos.Models
{

    public class VeiculoModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFab { get; set; }
        public decimal Km { get; set; }
        public string ChassiNum { get; set; }
    }
}