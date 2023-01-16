using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EjercicioPracticoBack.Models.ModelosVistas
{
    public class ClientesClase
    {
        [Display(Name = "ClienteId")]
        public int ClienteId { set; get; }
        [Display(Name = "Nombre")]
        public string Nombre { set; get; }
        [Display(Name = "Telefono")]
        public string Telefono { set; get; }
        [Display(Name = "Correo Electronico")]
        public string Correo { set; get; }
        [Display(Name = "Edad")]
        public int Edad { set; get; }
        [Display(Name = "Monto Solicitud")]
        public decimal Montosolicitud { set; get; }
        [Display(Name = "Estatus")]
        public string Estatus { set; get; }
        [Display(Name = "Aprobacion")]
        public int Aprobacion { set; get; }
        [Display(Name = "Fecha de Alta")]
        public DateTime FechaAlta { set; get; }
    }
}