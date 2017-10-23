namespace FarmaciaJa.API.Adapters.DTOs
{
    public class FarmaciaDTO
    {
        public int _id { get; set; }
        public string descFarmacia { get; set; }
        public string endereco { get; set; }
        public decimal mediaTempoEntrega { get; set; }
        public decimal mediaNotaAtendimento { get; set; }
        public string informacoesFarmacia { get; set; }
    }
}
