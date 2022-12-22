using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_BackEnd_Jr.Models
{
    public class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PagoID { get; set; }

        [Required]
        public int ClienteID{ get; set; }

        [Required]
        public decimal MontoPagado { get; set; }

        [Required]
        public byte Aplicado { get; set; }

        public DateTime FechaPago { get; set; } = DateTime.Now;

        [ForeignKey("ClienteID")]
        public virtual Cliente Cliente { get; set; }

    }
}
