using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaJa.API.Domain
{
    [Table("farmacia")]
    public class Farmacia
    {
        [Key]
        [Column("_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        [Required]
        [StringLength(255)]
        public string descFarmacia { get; set; }

        [Required]
        [StringLength(255)]
        public string endereco { get; set; }
        
        public decimal mediaTempoEntrega { get; set; }
        
        public decimal mediaNotaAtendimento { get; set; }

        [Required]
        [StringLength(255)]
        public string informacoesFarmacia { get; set; }
    }
}
