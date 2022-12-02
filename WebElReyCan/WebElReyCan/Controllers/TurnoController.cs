using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;



namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {
        private TurnoContext context = new TurnoContext();

    
        // GET: Turno
        public ActionResult Index()
        {
            List<Turno> lista = context.Turnos.ToList();
            return View("Index", lista);
        }


        //GET:Turno
        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View("Create", turno);
        }

        // POST: /Turno/Create
        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Turnos.Add(turno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", turno);
            }

        }

        //GET:Turno/Edit/id
        public ActionResult Edit(int id)
        {

            Turno turno = context.Turnos.Find(id);
            if (turno == null)
            {
                HttpNotFound();

            }
            return View("Edit", turno);

        }
        //POST : Turno/Edit/id
        [HttpPost]
        public ActionResult Edit(Turno turno)
        {

            if (ModelState.IsValid)
            {

                context.Entry(turno).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turno);

        }

        //GET:/Turno/Delete/id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Turno turno = context.Turnos.Find(id);
            if (turno == null)
            {
                return HttpNotFound();
            }
            return View("Delete", turno);
        }

        // POST: /Turno/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = context.Turnos.Find(id);
            if (turno != null)
            {
                context.Turnos.Remove(turno);
                context.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        public ActionResult IndexToday()
        {
            List<Turno> listaTurnos = context.Turnos.ToList();
            List<Turno> turnosHoy = new List<Turno>();
            foreach (Turno turno in listaTurnos)
            {
                if (turno.Fecha == DateTime.Now.Date)
                {
                    turnosHoy.Add(turno);
                }

            }
            return View("Index", turnosHoy);
        }

    }
}