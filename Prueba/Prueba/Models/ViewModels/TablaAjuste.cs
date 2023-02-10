using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models.ViewModels
{
    public class TablaAjuste
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Adeudo { get; set; }
    }
}