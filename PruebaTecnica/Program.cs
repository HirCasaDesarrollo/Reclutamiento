using System.Text.RegularExpressions;

namespace PruebaTecnica
{
    public class Program
    {
        static void Main(string[] args)
        {
            requerimientoNombres();

            requerimientoPagos();

            requerimientoEstadoAprobacion();

        }

        static void requerimientoEstadoAprobacion()
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.obtenerClientes();
            foreach(Cliente c in clientes)
            {
                actualizarEstadoAprobacion(c);
            }

            Console.WriteLine("\n--------------------------- Estado y Aprobacion Actualizados ");
            clientes = cliente.obtenerClientes();
            cliente.mostrarEstadoAprobacion(clientes);
        }

        static void actualizarEstadoAprobacion(Cliente cliente)
        {

            using (ApplicationDBContext contexto = new ApplicationDBContext())
            {
                Ajuste ajuste = contexto.Ajustes.Where( a => a.ClienteId == cliente.ClienteId).First();
                string estado = "";

                if (ajuste.Adeudo < 0) estado = "Adeudo";
                else if (ajuste.Adeudo == 0) estado = "Cancelacion";
                else estado = "Al corriente";

                cliente.Status = estado;

                string aprobacion = (estado == "Cancelacion") ? "0" : "1";
                cliente.Aprobacion = aprobacion;

                contexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                contexto.SaveChanges();
            }
        }


        static void requerimientoPagos()
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.obtenerClientes();
            foreach (Cliente c in clientes)
            {
                totalPagos(c.ClienteId, c.MontoSolicitud);
            }

            Console.WriteLine("\n--------------------------- Ajuste Actualizados ");
            Ajuste ajuste = new Ajuste();
            ajuste.mostrandoAjuste(ajuste.obtenerAjustes());
            
        }
        static void totalPagos(int identificador, decimal montoSolicitud)
        {
            
            using (ApplicationDBContext contexto = new ApplicationDBContext())
            {
                decimal totalPagos = contexto.Pagos.Where( p => p.ClienteId == identificador && p.Aplicado == 1).Sum( p => p.MontoPagado);
                decimal adeudo = montoSolicitud - totalPagos;
                Ajuste ajuste = contexto.Ajustes.Where( a => a.ClienteId == identificador ).First();
                ajuste.MontoTotal = totalPagos;
                ajuste.Adeudo = adeudo;
                contexto.Entry(ajuste).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        
        static void requerimientoNombres()
        {
            Cliente instanciaCliente = new Cliente();
            List<Cliente> clientes = instanciaCliente.obtenerClientes();

            Console.WriteLine("--------------------------- Mostrando Nombres de Clientes");
            instanciaCliente.mostrarClientes(clientes);

            Console.WriteLine("--------------------------- Nombres Limpiados");
            instanciaCliente.limpiandoNombres(clientes);
            clientes = instanciaCliente.obtenerClientes();
            instanciaCliente.mostrarClientes(clientes);
        }
    }
}