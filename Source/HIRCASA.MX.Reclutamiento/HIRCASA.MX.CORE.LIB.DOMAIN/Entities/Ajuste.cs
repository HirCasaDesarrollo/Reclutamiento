using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Entities;

public partial class Ajuste
{
    [Key]
    public int AjusteId { get; set; }

    public int ClienteId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Adeudo { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Ajustes")]
    public virtual Cliente Cliente { get; set; } = null!;
}
