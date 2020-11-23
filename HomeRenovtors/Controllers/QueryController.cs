using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class QueryController : Controller
    {

        // GET: Query

        HomeRenovatorsEntities instance = new HomeRenovatorsEntities();

        public ActionResult allQuery()
        {
            return View(instance.QueryDetails.ToList());
        }

        // GET: Query/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Query/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Query/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Query/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Query/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(QueryDetail qryDetail)
        {

            var d = instance.QueryDetails.Where(x => x.id == qryDetail.id).FirstOrDefault();
            instance.QueryDetails.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("allQuery");
        }

        // POST: Query/Delete/5
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
