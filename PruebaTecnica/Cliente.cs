using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }

        [Precision(precision: 9, scale: 2)]
        public decimal MontoSolicitud { get; set; }
        public string Status { get; set; }
        public string Aprobacion { get; set; }
        public DateTime FechaAlta { get; set; }


        public Ajuste Ajuste { get; set; }

        public List<Pago> Pago { get; set; }


        public List<Cliente> obtenerClientes()
        {
            using (ApplicationDBContext contexto = new ApplicationDBContext())
            {
                var list = contexto.Clientes;
                return list.ToList();
            }
        }

        public void mostrarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.Nombre);
            }
        }

        public void mostrarEstadoAprobacion(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("IdCliente: " + cliente.ClienteId + " -- Status: " + cliente.Status + " -- Aprobacion: "+ cliente.Aprobacion);
            }
        }

        public void limpiandoNombres(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                using (ApplicationDBContext contexto = new ApplicationDBContext())
                {
                    string nombreLimpio = limpiaCadena(cliente.Nombre);
                    cliente.Nombre = nombreLimpio;
                    contexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }

        }
        private string limpiaCadena(string nombreSucio)
        {
            Regex regex = new Regex(@"\s+");
            nombreSucio = regex.Replace(nombreSucio, " ");
            string nombreLimpio = nombreSucio.Trim();
            return nombreLimpio;
        }
 
    }
}
