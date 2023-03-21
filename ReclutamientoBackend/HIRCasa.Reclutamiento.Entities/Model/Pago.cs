using HIRCasa.Reclutamiento.Entities.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIRCasa.Reclutamiento.Entities;

[Table("Pagos", Schema = "dbo")]
public class Pago : Entity
{
    public Pago() { }

    public int ClienteId { get; set; }
    public float MontoPagado { get; set; }
    public Boolean Aplicado { get; set; } = false;
    public DateTime FechaPago { get; set; }

}
