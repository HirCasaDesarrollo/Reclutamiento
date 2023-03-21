using HIRCasa.Reclutamiento.Entities.Enums;
using HIRCasa.Reclutamiento.Entities.Model;
using HIRCasa.Reclutamiento.Entities.Model.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace HIRCasa.Reclutamiento.Entities
{
    [Table("Clientes", Schema ="dbo")]
    public class Cliente:Entity
    {
        public Cliente() { }

        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public int Edad { get; set; }
        public float MontoSolicitud { get; set; }
        public EstatusType Estatus { get; set; } = EstatusType.Pendiente;
        public Boolean Aprobación { get; set; } = false;
        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

        private List<Pago> _Pagos = new();
        public ICollection<Pago> Pagos => _Pagos;

        private List<Ajuste> _Ajustes = new();
        public ICollection<Ajuste> Ajustes => _Ajustes;

    }
}
