namespace SistemaDeVeiculos.Models
{

    public class VeiculoModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anoFab { get; set; }
        public decimal km { get; set; }
        public string chassiNum { get; set; }
    }
}