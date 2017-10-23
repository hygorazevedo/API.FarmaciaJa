namespace FarmaciaJa.API.Adapters.DTOs
{
    public class UsuarioDTO
    {
        public int _id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public int logado { get; set; }
        public int logarAuto { get; set; }
        public EnderecoDTO endereco { get; set; }
    }
}
