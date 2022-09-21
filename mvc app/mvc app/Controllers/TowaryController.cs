using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_app.Controllers
{
   // List<Towar> towary = new List<Towar>()
   //{
  //  new Towar{}
   // };
    // klase Towar stworz 
    public class TowaryController : Controller
    {
        // GET: TowaryController
        public ActionResult Index()
        {
            return View();//zwroc liste towary
        }

        // GET: TowaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TowaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TowaryController/Create
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

        // GET: TowaryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TowaryController/Edit/5
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

        // GET: TowaryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TowaryController/Delete/5
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
