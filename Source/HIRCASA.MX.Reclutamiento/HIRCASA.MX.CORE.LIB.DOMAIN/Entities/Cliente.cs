using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Entities;

public partial class Cliente
{
    [Key]
    public int ClientId { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(16)]
    public string? Telefono { get; set; }

    [StringLength(50)]
    public string Correo { get; set; } = null!;

    public int Edad { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MontoSolicitud { get; set; }

    [StringLength(16)]
    public string? Estatus { get; set; }

    public bool? Aprobacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaAlta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Ajuste> Ajustes { get; } = new List<Ajuste>();

    [InverseProperty("Cliente")]
    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();
}
