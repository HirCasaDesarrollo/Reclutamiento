using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prueba.Controllers;
using Prueba.Models;
using Prueba.Models.ViewModels;

namespace Prueba.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<TablaViweModel> lst;
            using (PruebaEntities db = new PruebaEntities())
            {
                lst = (from d in db.Clientes
                       select new TablaViweModel
                       {
                           Id = d.ClienteId,
                           Nombre = d.Nombre,
                           Telefono = d.Telefono,
                           Correo = d.Correo,
                           Edad = (int)d.Edad,
                           MontoSolicitado = (decimal)d.MontoSolicitud,
                           Estatus = d.Estatus,
                           Aprobacion = (int)d.Aprobaciòn,
                           FechaAlta = (DateTime)d.FechaAlta
                       }).ToList();

            }
            List<TablaPagos> lstP;
            using (PruebaEntities db2 = new PruebaEntities())
            {
                lstP = (from d in db2.Pagos
                        select new TablaPagos
                        {
                            Id = d.PagoId,
                            ClienteId = (int)d.ClienteId,
                            MontoPago = (decimal)d.MontoPagado,
                            Aplicado = (int)d.Aplicado,
                            FechaPago = (DateTime)d.FechaPago
                        }).ToList();
            }

            List<TablaAjuste> lstA;
            using (PruebaEntities db3 = new PruebaEntities())
            {
                lstA = (from d in db3.Ajustes
                        select new TablaAjuste
                        {
                            Id = d.AjusteId,
                            ClienteId = (int)d.ClienteId,
                            MontoTotal = (decimal)d.MontoTotal,
                            Adeudo = (decimal)d.Adeudo
                        }).ToList();
            }

            foreach (var t in lstP)
            {
                if (t.Aplicado == 1)
                {
                    foreach (var A in lstA)
                    {
                        if (t.ClienteId == A.ClienteId)
                        {
                            A.MontoTotal += t.MontoPago;
                            foreach (var C in lst)
                            {
                                if (C.Id == A.ClienteId)
                                {
                                    A.Adeudo = t.MontoPago - C.MontoSolicitado;
                                    if (A.Adeudo < 0)
                                    {
                                        C.Estatus = "Adeudo";
                                    }
                                    if (A.Adeudo > 0)
                                    {
                                        C.Estatus = "Al corriente";
                                    }
                                    if (A.Adeudo == 0)
                                    {
                                        C.Estatus = "Cancelación";
                                    }
                                }
                                if (C.Estatus == "Adeudo" || C.Estatus == "Al corriente")
                                {
                                    C.Aprobacion = 1;
                                }
                                else
                                {
                                    C.Aprobacion = 0;
                                }
                            }
                        }
                    }
                }
            }
            return View(lst);
        }

    }
}
