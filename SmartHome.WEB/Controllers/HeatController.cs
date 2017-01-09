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
        // GET: Boiler
        public ActionResult Index()
        {
            HeatService bs = new HeatService();
            return View(bs.GetAll());
        }

        // GET: Boiler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Boiler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Boiler/Create
        [HttpPost]
        public ActionResult Create(HeatViewModel boiler)
        {
            try
            {
                HeatService bs = new HeatService();
                bs.AddItem(boiler);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Boiler/Edit/5
        public ActionResult Edit(Guid id)
        {
            HeatService bs = new HeatService();
            HeatViewModel boiler = bs.GetAll().First(n => n.Id == id);
            return View(boiler);
        }

        // POST: Boiler/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, HeatViewModel boiler)
        {
            try
            {
                HeatService bs = new HeatService();
                bs.EditItem(boiler);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Boiler/Delete/5
        public ActionResult Delete(Guid id)
        {
            HeatService bs = new HeatService();
            bs.DeleteItem(id);
            return RedirectToAction("Index");
        }

        // POST: Boiler/Delete/5
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
