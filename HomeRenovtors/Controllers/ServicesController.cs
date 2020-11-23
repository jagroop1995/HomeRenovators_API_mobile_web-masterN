using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class ServicesController : Controller
    {

        // GET: Services
        HomeRenovatorsEntities instance = new HomeRenovatorsEntities();

        public ActionResult allServices()
        {
            return View(instance.ServiceDetails.ToList());
        }

        public ActionResult viewServices()
        {
            return View(instance.ServiceDetails.ToList());
        }



        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(ServiceDetail serviceDetail)
        {
            if (!ModelState.IsValid)
                return View();
            instance.ServiceDetails.Add(serviceDetail);
            instance.SaveChanges();
            return RedirectToAction("allServices");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in instance.ServiceDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(ServiceDetail serviceDetail)
        {

            var orignalRecord = (from m in instance.ServiceDetails where m.id == serviceDetail.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            instance.Entry(orignalRecord).CurrentValues.SetValues(serviceDetail);

            instance.SaveChanges();
            return RedirectToAction("allServices");
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(ServiceDetail serviceDetail)
        {

            var d = instance.ServiceDetails.Where(x => x.id == serviceDetail.id).FirstOrDefault();
            instance.ServiceDetails.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("allServices");
        }

        // POST: Services/Delete/5
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
