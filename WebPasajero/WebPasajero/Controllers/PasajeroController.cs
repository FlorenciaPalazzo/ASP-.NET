using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPasajero.Data;
using WebPasajero.Models;

namespace WebPasajero.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly PasajeroContext _context;
        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Pasajeros.ToList());
        }


        //GET:/Pasajero/
        public IActionResult Create()
        {
            Pasajero pasajero = new Pasajero();
            return View("Create", pasajero);
        }

        // POST: /Person/Create
        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            _context.Add(pasajero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/pasajero/ListaPorCiudad/{ciudad}")]
        // GET: /person/ListaPorCiudad/baas
        public IActionResult ListaPorCiudad(string ciudad)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.Ciudad == ciudad
                                  select p).ToList();
            return View("Index", lista);
        }

        //GET
        //FILTRADO EXCLUSIVO PARA FECHAS!!!!!
        [HttpGet("/pasajero/ListarPorFechaNacimiento/{fechaNacimiento}")]
        // GET: /person/ListaPorCiudad/baas
        public IActionResult ListarPorFechaNacimiento(DateTime nacimiento)
        {
            List<Pasajero> listAll = _context.Pasajeros.ToList();
            List<Pasajero> list = new List<Pasajero>();
            foreach (Pasajero pasajero in listAll)
            {
                if (pasajero.FechaNacimiento == nacimiento)
                {
                   
                    list.Add(pasajero);
                }
            }
            return View("Index", list);
        }
    }
}



