using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fechas.Models;

namespace Fechas.Controllers
{
    public class CitasController : Controller
    {
        DoctorTesisEntities entidad = new DoctorTesisEntities();
        // GET: Citas
        [HttpGet]
        public ActionResult Index()
        {
            var listacitas = entidad.citas;
            ViewBag.formato = "Para mayor información por favor seguir el vinculo correspondiente";
            return View(listacitas.ToList());
        }
        public ActionResult ListaMaestraCitas()
        {
            var listacitas = entidad.citas;
            return View(listacitas.ToList());
        }
        public ActionResult ListadoCitas()
        {
            var modelo = from p in entidad.citas

                         select new CLCitas
                         {
                             Num = p.Num,
                             Formato = p.Formato,
                             Revision = p.Revision,
                             Cuando_usar = p.Cuando_usar                             
                         };
            

            return View(modelo.ToList());
        }
        public ActionResult Vista()
        {
            return View();
        }
    }
}