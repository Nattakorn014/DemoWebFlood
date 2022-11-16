using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebFlood.Controllers
{
    public class TypeControllers : Controller
    {
        // GET: TypeControllers
        public ActionResult Index()
        {
            return View();
        }

        // GET: TypeControllers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeControllers/Create
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

        // GET: TypeControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeControllers/Edit/5
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

        // GET: TypeControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeControllers/Delete/5
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
