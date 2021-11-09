using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroAutomatico.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(Cajero c)
        {
            _ = c;

            if(c.Monto % 5 == 0)
            {
                return View("PaginaCorrecta");
            }
            else
            {
                return View("PaginaError");
            }
        }

        [HttpGet]
        public ActionResult PaginaError()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PaginaCorrecta()
        {
            return View();
        }
    }
}