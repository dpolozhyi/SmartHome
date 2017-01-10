using SmartHome.BL.DTO;
using SmartHome.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHome.WEB.Controllers
{
    public class HeatController : Controller
    {
        private HeatService heatService;

        public HeatController()
        {
            this.heatService = new HeatService();
        }

        public ActionResult Index()
        {
            return View(heatService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HeatViewModel heatDevice)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                heatService.AddItem(heatDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            HeatViewModel heatDevice = heatService.GetAll().First(n => n.Id == id);
            return View(heatDevice);
        }

        [HttpPost]
        public ActionResult Edit(Guid id, HeatViewModel heatDevice)
        {
            if (!ModelState.IsValid)
            {
                return View(heatDevice);
            }

            try
            {
                heatService.EditItem(heatDevice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            heatService.DeleteItem(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
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
