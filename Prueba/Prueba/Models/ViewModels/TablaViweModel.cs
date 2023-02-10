using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models.ViewModels
{
    public class TablaViweModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public decimal MontoSolicitado { get; set; }
        public string Estatus { get; set; }
        public int Aprobacion { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}