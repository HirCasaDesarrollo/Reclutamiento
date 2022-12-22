using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_BackEnd_Jr.DAL;
using Prueba_BackEnd_Jr.Models;
using System.Diagnostics;

namespace Prueba_BackEnd_Jr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext _context;


        public HomeController(ILogger<HomeController> logger, DataBaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["connError"] = ErrorConexion(_context);

            return View();
        }

        public IActionResult Reinicio()
        {
            try
            {
                DbInitializer.Initialize(_context, false);

                ViewData["mensaje"] = "Base de datos restablecida";
            }
            catch (Exception)
            {
                ViewData["connError"] = "error";
                ViewData["mensaje"] = "Error con la base de datos";
            }

            return View("Index");
        }

        public IActionResult Conexion()
        {
            try
            {
                ViewData["connError"] = ErrorConexion(_context);
                ViewData["mensaje"] = "Base de datos restablecida";
                return View("Index");
            }
            catch (Exception)
            {
                ViewData["connError"] = "error";
                return View("Index");
            }
        }

        private static string ErrorConexion(DataBaseContext context)
        {
            if (context.Database.CanConnect())
            {
                return null;
            }
            else
            {
                return "error";
            }
        }

        /*-------------------------------------------------------------- Requerimiento 1 -------------------------------------------------------------------------*/
        public IActionResult Prueba1()
        {

                var clientes = _context.Clientes.ToList();

                // Muestra los nombres con espacios extras por consola, ya que ASP formatea estos datos automaticamente
                // en la vista y no se logra apreciar tales espacios extras contenidos en la DB
                Console.WriteLine("-- Nombres con espacios extras --");
                foreach (var c in clientes)
                {
                    Console.WriteLine("|" + c.Nombre + "|");
                }

                return View(clientes);
        }

        public IActionResult Prueba1Solucion()
        {
            var clientes = _context.Clientes.ToList();
            foreach (var c in clientes)
            {
                c.Nombre = SinEspaciosExtras(c.Nombre);
                _context.Update(c);
            }
            _context.SaveChanges();

            // Vuelve a traer los datos de la DB, para verificar la eliminación de los espacios extras
            clientes = _context.Clientes.ToList();

            // y los muestra por consola
            Console.WriteLine("-- Nombres sin espacios extras --");
            foreach (var c in clientes)
            {
                Console.WriteLine("|" + c.Nombre + "|");
            }

            ViewData["mensaje"] = "Requerimiento Solucionado, revisa la consola";

            return View("Prueba1", clientes);
        }


        // Metodo para eliminar espacios extras
        private static string SinEspaciosExtras(string s)
        {
            // Crea un string auxiliar (aux) el cual no tiene espacios ni al principio ni al final
            // gracias a la funcion Trim()
            string aux = s.Trim();

            // Despues, recoré el string auxiliar para encuentar un espacio (que este entre el string)
            for (var i = 0; i < aux.Length; i++)
            {
                if (aux[i] == ' ')
                {
                    // Si lo encuentra, verifica que no haya más espacios adelante de este, iniciando un loop
                    // que mira los caracteres posteriores al espacio encontrado
                    do
                    {
                        // Si encuentra otro espacio, lo remueve
                        if (aux[i + 1] == ' ')
                        {
                            aux = aux.Remove(i + 1, 1);
                        }
                        
                    // Y continuara así hasta que el siguiente caracter del 1er espacio encontrado no sea otro espacio
                    }
                    while (aux[i + 1] == ' ');
                }
            }

            // Al final devuelve el string aux que ya esta sin espacios extras
            return aux;
        }

        /*-------------------------------------------------------------- Requerimiento 2 -------------------------------------------------------------------------*/
        public IActionResult Prueba2()
        {
            var ajustes = _context.Ajustes.Include(c => c.Cliente).ToList();

            return View(ajustes);
        }
        public IActionResult Prueba2Solucion()
        {
            var ajustes = _context.Ajustes.ToList();
            var pagos = _context.Pagos.ToList();

            decimal[] montosTotales = new decimal[ajustes.Count + 1];

            foreach (var p in pagos)
            {
                if (p.Aplicado == 1)
                {
                    montosTotales[p.ClienteID] += p.MontoPagado;
                }
            }

            foreach (var a in ajustes)
            {
                a.MontoTotal = montosTotales[a.ClienteID];
                _context.Update(a);
            }
            _context.SaveChanges();

            ajustes = _context.Ajustes.Include(c => c.Cliente).ToList();

            ViewData["mensaje"] = "Requerimiento Solucionado, puedes pasar al requerimiento 3";

            return View("Prueba2", ajustes);
        }

        /*-------------------------------------------------------------- Requerimiento 3 -------------------------------------------------------------------------*/
        public IActionResult Prueba3()
        {
            var ajustes = _context.Ajustes.Include(c => c.Cliente).ToList();

            return View(ajustes);
        }

        public IActionResult Prueba3Solucion()
        {
            var ajustes = _context.Ajustes.Include(c => c.Cliente).ToList();

            if (ajustes.Find(c => c.AjusteID == 4)?.MontoTotal is null)
            {
                ViewData["mensaje"] = "Para solucionar este reqeurimiento, debes de solucionar el requerimiento 2 antes";
                return View("Prueba3", ajustes);
            }


            foreach (var a in ajustes)
            {
                a.Adeudo = a.Cliente.MontoSolicitado - a.MontoTotal;
                _context.Update(a);
            }
            _context.SaveChanges();

            ajustes = _context.Ajustes.Include(c => c.Cliente).ToList();

            ViewData["mensaje"] = "Requerimiento Solucionado, puedes pasar al requerimiento 4";

            return View("Prueba3", ajustes);
        }

        /*-------------------------------------------------------------- Requerimiento 4 -------------------------------------------------------------------------*/
        public IActionResult Prueba4()
        {
            var clientes = _context.Clientes.ToList();

            return View(clientes);
        }

        public IActionResult Prueba4Solucion()
        {
            var clientes = _context.Clientes.Include(a => a.Ajuste).ToList();

            if (_context.Ajustes.Find(4)?.Adeudo is null)
            {
                ViewData["mensaje"] = "Para solucionar este requerimiento, debes de solucionar el requerimiento 3 antes";
                return View("Prueba4", clientes);
            }

            foreach (var c in clientes)
            {
                if (c.Ajuste.Adeudo < 0)
                {
                    c.Estatus = "Adeudo";

                }
                else if (c.Ajuste.Adeudo > 0)
                {
                    c.Estatus = "Al corriente";
                }
                else
                {
                    c.Estatus = "Cancelación";
                }

                _context.Update(c);
            }
            _context.SaveChanges();

            clientes = _context.Clientes.ToList();
            ViewData["mensaje"] = "Requerimiento Solucionado, puedes pasar al requerimiento 5";

            return View("Prueba4", clientes);
        }

        /*-------------------------------------------------------------- Requerimiento 5 -------------------------------------------------------------------------*/
        public IActionResult Prueba5()
        {
            var clientes = _context.Clientes.ToList();

            return View(clientes);
        }

        public IActionResult Prueba5Solucion()
        {
            var clientes = _context.Clientes.ToList();

            if (clientes.Find(c => c.ClienteID == 4)?.Estatus is null)
            {
                ViewData["mensaje"] = "Para solucionar este requerimiento, debes de solucionar el requerimiento 4 antes";
                return View("Prueba5", clientes);
            }


            foreach (var c in clientes)
            {
                switch (c.Estatus)
                {
                    case "Al corriente":
                    case "Adeudo":
                        c.Aprobacion = "1";
                        break;
                    case "Cancelación":
                        c.Aprobacion = "0";
                        break;
                    default:
                        c.Aprobacion = "";
                        break;
                }
               
                _context.Update(c);
            }
            _context.SaveChanges();

            clientes = _context.Clientes.ToList();
            ViewData["mensaje"] = "Requerimiento Solucionado, ¡Fabuloso!, Han pasado todos los requerimientos";

            return View("Prueba5", clientes);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}