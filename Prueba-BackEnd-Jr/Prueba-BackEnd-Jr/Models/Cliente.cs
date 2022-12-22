using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_BackEnd_Jr.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public decimal MontoSolicitado { get; set; }

        [MaxLength(20)]
        public string? Estatus { get; set; } = null;

        [MaxLength(9)]
        public string? Aprobacion { get; set; } = null;

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual Ajuste Ajuste { get; set; }
    }
}
