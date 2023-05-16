using Microsoft.AspNetCore.Mvc;
using AgendaMedica.Models;
using System.Text.RegularExpressions;

namespace AgendaMedica.Controllers
{
    public class UsuarioController : Controller
    {
        private BdagendaContext db = new();

        public IActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            db.Add(usuario);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var usuario = db.Usuarios.Find(id);

                if (usuario != null)
                {
                    return View(usuario);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
