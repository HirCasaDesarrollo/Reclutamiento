using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using EjercicioPracticoBack.Models;


namespace EjercicioPracticoBack.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            List<Clientes> ListaClientes = null;
            using (var db = new ArchivosExcelEntities1())
            {
                ListaClientes = (from cliente in db.Clientes
                                 select new Clientes
                                 {
                                     ClienteId = (int)cliente.ClienteId,
                                     Nombre=cliente.Nombre,
                                     Telefono=cliente.Telefono,
                                     Correo=cliente.Correo,
                                     Edad=(int)cliente.Edad,
                                     MontoSolicitud=(decimal)cliente.MontoSolicitud,
                                     Estatus=cliente.Estatus,
                                     Aprobacion=(int)cliente.Aprobacion,
                                     FechaAlta=(DateTime)cliente.FechaAlta
                                 }).ToList();
            }
                return View(ListaClientes);
        }
    }
}