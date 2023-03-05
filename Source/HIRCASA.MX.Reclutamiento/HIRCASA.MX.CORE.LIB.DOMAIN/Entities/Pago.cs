using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Entities;

public partial class Pago
{
    [Key]
    public int PagoId { get; set; }

    public int ClienteId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoPagado { get; set; }

    public bool Aplicado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaPago { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Pagos")]
    public virtual Cliente Cliente { get; set; } = null!;
}
