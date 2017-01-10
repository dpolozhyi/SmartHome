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
        private AudioService audioService;

        public AudioController()
        {
            this.audioService = new AudioService();
        }

        public ActionResult Index()
        {
            return View(audioService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Types = new SelectList(audioService.GetTypesList());
            return View();
        }

        [HttpPost]
        public ActionResult Create(AudioViewModel audioDevice)
        {
            ViewBag.Types = new SelectList(audioService.GetTypesList());
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                audioService.AddItem(audioDevice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            AudioViewModel audioDevice = audioService.GetAll().First(n => n.Id == id);
            return View(audioDevice);
        }

        [HttpPost]
        public ActionResult Edit(AudioViewModel audioDevice)
        {
            if (!ModelState.IsValid)
            {
                return View(audioDevice);
            }

            try
            {
                audioService.EditItem(audioDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            audioService.DeleteItem(id);
            return RedirectToAction("Index");
        }

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
