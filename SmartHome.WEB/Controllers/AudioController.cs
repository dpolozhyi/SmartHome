using SmartHome.BL.DTO;
using SmartHome.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHome.WEB.Controllers
{
    public class AudioController : Controller
    {
        // GET: Audio
        public ActionResult Index()
        {
            AudioService ads = new AudioService();
            return View(ads.GetAll());
        }

        // GET: Audio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Audio/Create
        public ActionResult Create()
        {
            AudioService ads = new AudioService();
            ViewBag.Types = new SelectList(ads.GetTypesList());
            return View();
        }

        // POST: Audio/Create
        [HttpPost]
        public ActionResult Create(AudioViewModel audioDevice)
        {
            AudioService ads = new AudioService();
            ViewBag.Types = new SelectList(ads.GetTypesList());
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                ads.AddItem(audioDevice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Audio/Edit/5
        public ActionResult Edit(Guid id)
        {
            AudioService ads = new AudioService();
            AudioViewModel audio = ads.GetAll().First(n => n.Id == id);
            return View(audio);
        }

        // POST: Audio/Edit/5
        [HttpPost]
        public ActionResult Edit(AudioViewModel audioDevice)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                AudioService ads = new AudioService();
                ads.EditItem(audioDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Audio/Delete/5
        public ActionResult Delete(Guid id)
        {
            HeatService bs = new HeatService();
            bs.DeleteItem(id);
            return RedirectToAction("Index");
        }

        // POST: Audio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
