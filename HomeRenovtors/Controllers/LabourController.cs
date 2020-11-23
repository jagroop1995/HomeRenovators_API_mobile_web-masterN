using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class LabourController : Controller
    {
        // GET: Labour
        HomeRenovatorsEntities instance = new HomeRenovatorsEntities();

        public ActionResult allLabour()
        {
            return View(instance.SkilledLabourDetails.ToList());
        }

        public ActionResult viewSkilledWorker()
        {
            return View(instance.SkilledLabourDetails.ToList());
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
        public ActionResult Create(SkilledLabourDetail skillDetail)
        {
            if (!ModelState.IsValid)
                return View();
            instance.SkilledLabourDetails.Add(skillDetail);
            instance.SaveChanges();
            return RedirectToAction("allLabour");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in instance.SkilledLabourDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(SkilledLabourDetail skillDetail)
        {

            var orignalRecord = (from m in instance.SkilledLabourDetails where m.id == skillDetail.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            instance.Entry(orignalRecord).CurrentValues.SetValues(skillDetail);

            instance.SaveChanges();
            return RedirectToAction("allLabour");
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(SkilledLabourDetail skillDetail)
        {

            var d = instance.SkilledLabourDetails.Where(x => x.id == skillDetail.id).FirstOrDefault();
            instance.SkilledLabourDetails.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("allLabour");
        }

        // POST: Labour/Delete/5
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
