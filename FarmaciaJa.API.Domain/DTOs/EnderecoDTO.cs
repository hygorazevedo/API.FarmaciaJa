namespace FarmaciaJa.API.Domain.DTOs
{
    public class EnderecoDTO
    {
        public int _id { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string Estado { get; set; }
    }
}
