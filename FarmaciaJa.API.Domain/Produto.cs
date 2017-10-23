using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaJa.API.Domain
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [Column("_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }
        
        public int farmacia_id { get; set; }

        [Required]
        [StringLength(255)]
        public string descProduto { get; set; }

        [Required]
        [StringLength(100)]
        public string nomeProduto { get; set; }
        
        [Column(TypeName = "money")]
        public decimal valorProduto { get; set; }
    }
}
