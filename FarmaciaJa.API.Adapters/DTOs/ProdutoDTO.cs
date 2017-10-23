namespace FarmaciaJa.API.Adapters.DTOs
{
    public class ProdutoDTO
    {
        public int _id { get; set; }
        public int farmacia_id { get; set; }
        public string descProduto { get; set; }
        public string nomeProduto { get; set; }
        public double valorProduto { get; set; }
    }
}
