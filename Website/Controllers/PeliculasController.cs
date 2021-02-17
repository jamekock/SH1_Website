using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Website.Models;
namespace Website.Controllers
{
    public class PeliculasController : Controller
    {
        // POST: ../Peliculas/
        //[HttpPost]
        public ActionResult Index() //FormCollection collection
        {
            var data = new CrudModel().Consulta();
            return View(data);
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST:Peliculas/Create
        [HttpPost]
        public ActionResult Create(CrudModel model)
        {
            
            new CrudModel().Insertar(model);
            return RedirectToAction("/Index");
        }

        // GET: Peliculas/Delete
        public ActionResult Delete(int id)
        {
            new CrudModel().Eliminar(id);
            return RedirectToAction("/Index");
        }

        // GET: Peliculas/Create
        public ActionResult Edit(int id)
        {
            var data = new CrudModel().Consulta(id);
            return View(data);
        }

        // POST:Peliculas/Edit
        [HttpPost]
        public ActionResult Edit(CrudModel model)
        {
            new CrudModel().Actualizar(model);
            return RedirectToAction("/Index");
        }




    }
}