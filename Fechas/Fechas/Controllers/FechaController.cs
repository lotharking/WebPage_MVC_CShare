using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fechas.Models;

namespace Fechas.Controllers
{
    public class FechaController : Controller
    {
        DoctorTesisEntities entidad = new DoctorTesisEntities();
        // GET: Fecha
        public ActionResult Index()
        {
            var listafechas = entidad.fechas;
            return View(listafechas.ToList());
        }
        public ActionResult ListaMaestraFechas()
        {
            var listafechas = entidad.fechas;
            return View(listafechas.ToList());
        }
        public ActionResult ListadoFechas()
        {
            var modelo = from p in entidad.fechas

                         select new CLFecha
                         {
                             Nombre = p.Nombre,
                             Dia = p.Dia,
                             Mes = p.Mes,
                             Año = p.Año,
                             Descripcion = p.Descripcion
                         };
            return View(modelo.ToList());
        }
    }
}