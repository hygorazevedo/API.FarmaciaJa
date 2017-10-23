using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaJa.API.Domain
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [StringLength(80)]
        public string email { get; set; }

        [Required]
        [StringLength(11)]
        public string telefone { get; set; }
        
        [Required]
        [StringLength(50)]
        public string usuario { get; set; }

        [Required]
        [StringLength(30)]
        public string senha { get; set; }
        
        public int logado { get; set; }
        
        public int logarAuto { get; set; }
        
        public virtual Endereco endereco { get; set; }
    }
}
