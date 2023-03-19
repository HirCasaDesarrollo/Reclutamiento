using HIRCasa.Reclutamiento.Entities.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIRCasa.Reclutamiento.Entities;

[Table("Ajustes", Schema = "dbo")]
public class Ajuste : Entity
{
    public Ajuste() { }

    public int ClienteId { get; set; }
    public float MontoTotal { get; set; }
    public float Adeudo { get; set; }

}
