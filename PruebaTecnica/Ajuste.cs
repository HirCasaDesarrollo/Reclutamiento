using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Ajuste
    {
        [Key]
        public int AjusteId { get; set; }

        [Precision(precision: 9, scale:2)]
        public decimal MontoTotal { get; set; }

        [Precision(precision: 9, scale: 2)]
        public decimal Adeudo { get; set; }

        //Uno a Uno con Cliente
        public int ClienteId { get; set; }


        public List<Ajuste> obtenerAjustes()
        {
            using (ApplicationDBContext contexto = new ApplicationDBContext())
            {
                var list = contexto.Ajustes;
                return list.ToList();
            }
        }

        public void mostrandoAjuste(List<Ajuste> ajustes)
        {
            foreach (Ajuste ajuste in ajustes)
            {
                Console.WriteLine("IdCliente: " + ajuste.ClienteId + " - Monto Total: " + ajuste.MontoTotal + " -- Adeudo: "+ ajuste.Adeudo);
            }
        }
    }
}
