using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models.ViewModels
{
    public class TablaPagos
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal MontoPago { get; set; }
        public int Aplicado { get; set; }
        public DateTime FechaPago { get; set; }
    }
}