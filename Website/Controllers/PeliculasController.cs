using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class PeliculasController : Controller
    {
        // POST: ../Peliculas/
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            ViewBag.Peliculas = collection;
            return View();
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }




    }
}