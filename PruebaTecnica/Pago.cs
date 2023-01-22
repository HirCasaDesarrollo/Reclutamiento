using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }

        [Precision(precision: 9, scale: 2)]
        public decimal MontoPagado { get; set; }
        public int Aplicado { get; set; }
        public DateTime FechaPago { get; set; }

        //Uno a muchos
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set;}

        
    }
}
