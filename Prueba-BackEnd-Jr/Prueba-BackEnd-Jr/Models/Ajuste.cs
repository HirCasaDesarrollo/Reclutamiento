using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_BackEnd_Jr.Models
{
    public class Ajuste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AjusteID { get; set; }

        [Required]
        public int ClienteID { get; set; }
        public decimal? MontoTotal { get; set; } 
        public decimal? Adeudo { get; set; }

        [ForeignKey("ClienteID")]
        public virtual Cliente Cliente { get; set; }
    }
}
