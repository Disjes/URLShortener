using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URLShortener.Controllers
{
    public class BlueBinCntroller : Controller
    {
        // GET: BlueBinCntroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlueBinCntroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlueBinCntroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlueBinCntroller/Create
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

        // GET: BlueBinCntroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlueBinCntroller/Edit/5
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

        // GET: BlueBinCntroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlueBinCntroller/Delete/5
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
