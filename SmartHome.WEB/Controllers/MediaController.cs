using SmartHome.BL.DTO;
using SmartHome.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHome.WEB.Controllers
{
    public class MediaController : Controller
    {
        private MediaService mediaService;

        public MediaController()
        {
            this.mediaService = new MediaService();
        }

        // GET: Media
        public ActionResult Index()
        {
            return View(mediaService.GetAll());
        }

        [HttpPost]
        public ActionResult Index(MediaViewModel mediaDevice)
        {

            return View(mediaService.GetAll());
        }

        // GET: Media/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Media/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Media/Create
        [HttpPost]
        public ActionResult Create(MediaViewModel mediaDevice)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                mediaService.AddItem(mediaDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Media/Edit/5
        public ActionResult Edit(Guid id)
        {
            MediaViewModel mediaDevice = mediaService.GetAll().First(n => n.Id == id);
            ViewBag.Channels = mediaDevice.Channels;
            return View(mediaDevice);
        }

        // POST: Media/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, MediaViewModel mediaDevice)
        {
            if (!ModelState.IsValid)
            {
                return View(mediaDevice);
            }

            try
            {
                mediaService.EditItem(mediaDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Media/Delete/5
        public ActionResult Delete(Guid id)
        {
            mediaService.DeleteItem(id);
            return RedirectToAction("Index");
        }

        // POST: Media/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
