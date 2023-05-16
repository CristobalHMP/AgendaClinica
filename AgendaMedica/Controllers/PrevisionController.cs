using Microsoft.AspNetCore.Mvc;
using AgendaMedica.Models;
using System.Text.RegularExpressions;

namespace AgendaMedica.Controllers
{
    public class PrevisionController : Controller
    {

        private BdagendaContext db = new();

        public IActionResult Index()
        {
            return View(db.Previsions.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Prevision prevision)
        {
            db.Add(prevision);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var prevision = db.Previsions.Find(id);

                if (prevision != null)
                {
                    return View(prevision);
                }
            }
            return RedirectToAction("Index");
        }
    }
}