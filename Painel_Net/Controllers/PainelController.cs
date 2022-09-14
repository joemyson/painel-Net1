using Microsoft.AspNetCore.Mvc;
using Painel_Net.Config;
using Painel_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Painel_Net.Controllers
{
    public class PainelController : Controller
    {
        private readonly Context _context;

        public PainelController(Context Context)
        {
            _context = Context;

        }


        [HttpPost("/api/ListaSenhas")]
       public JsonResult ListaSenhas ()
        {
            var senhas = _context.Painel.Take(5)
                .OrderByDescending(c=>c.Id).ToList();
            return Json(new { senhas = senhas, senha = senhas.FirstOrDefault() });
        }


        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Create(Painel painel)
        {
            try
            {
                _context.Painel.Add(painel);
                _context.SaveChanges();

                return RedirectToAction(nameof(Create));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
