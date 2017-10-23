using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaJa.API.Domain
{
    [Table("endereco")]
    public class Endereco
    {
        [Key]
        [Column("_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int _id { get; set; }

        [Required]
        [StringLength(200)]
        public string logradouro { get; set; }
        
        public int numero { get; set; }

        [StringLength(80)]
        public string complemento { get; set; }

        [Required]
        [StringLength(100)]
        public string bairro { get; set; }

        [Required]
        [StringLength(100)]
        public string cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string estado { get; set; }

        public virtual Usuario usuario { get; set; }
    }
}
