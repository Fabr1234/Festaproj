using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_1.Models;

namespace Projeto_1.Controllers
{
    public class ConvidadoController : Controller
    {
        public static IList<Convidado> ConvidadoList = new List<Convidado>()
        {
            new Convidado()
            {
                ConvidadosID = 1,
                Nome = "Fabrício Terra",
                Email = "lima.de.terra@hotmail.com",
                Telefone = "(35) 9 9720-4000",
                Comparecimento = true
            },
            new Convidado()
            {
                ConvidadosID = 2,
                Nome = "Luisa Cardoso Azola",
                Email = "luisaazolaC@gmail.com",
                Telefone = "(35) 9 8836-7412",
                Comparecimento = false
            },
        };
        // GET: ConvidadoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConvidadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConvidadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConvidadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConvidadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConvidadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConvidadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConvidadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
