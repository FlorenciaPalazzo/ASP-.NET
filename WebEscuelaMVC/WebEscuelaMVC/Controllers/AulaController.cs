using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        //Instancia
        private AulaDBContext context = new AulaDBContext();

        // GET: Aula
        public ActionResult Index()
        {
            List<Aula> lista = context.Aulas.ToList();
            return View("Index",lista);
        }

        //GET: Aula/Create
        public ActionResult Create() 
        {
            Aula aula = new Aula();
            return View("Create", aula);
         }

        //POST: Aula/Create
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }
        //GET: Aula/id
        public ActionResult Detail(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                HttpNotFound();
            }
            return View("Detail", aula);

        }


    }
}