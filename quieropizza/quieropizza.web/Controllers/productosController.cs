
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.web.Controllers
{
    public class productosController : Controller
    {
        // GET: productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.Obtenerproductos();


            return View(listadeproductos);
        }
    }
}