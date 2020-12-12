using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URLShortener.Controllers
{
    public class BlueBinController : Controller
    {
        URLShortener.Contexts.URLShortenerContext context = new Contexts.URLShortenerContext();
        // GET: BlueBinCntroller
        public ActionResult Index()
        {
            var list = context.Urls.ToList();
            return View(list);
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
        public ActionResult Create(URLShortener.Models.Url url)
        {            
            try
            {
                URLShortener.Logic.URLShortenerService shortenerService = new Logic.URLShortenerService(url.UrlOriginal, null);
                string shortenedUrl = shortenerService.shortenUrl();
                url.UrlShortened = shortenedUrl;
                context.Urls.Add(url);
                context.SaveChanges();
                return RedirectToAction(nameof(Index), url);
            }
            catch(Exception ex)
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
