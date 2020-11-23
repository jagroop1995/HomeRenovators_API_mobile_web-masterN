using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        HomeRenovatorsEntities instance = new HomeRenovatorsEntities();
        public ActionResult allEmployee()
        {
            return View(instance.StaffDetails.ToList());
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
        public ActionResult Create(StaffDetail staffDetail)
        {
            if (!ModelState.IsValid)
                return View();
            instance.StaffDetails.Add(staffDetail);
            instance.SaveChanges();
            return RedirectToAction("allEmployee");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in instance.StaffDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(StaffDetail staffDetail)
        {

            var orignalRecord = (from m in instance.StaffDetails where m.id == staffDetail.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            instance.Entry(orignalRecord).CurrentValues.SetValues(staffDetail);

            instance.SaveChanges();
            return RedirectToAction("allEmployee");
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(StaffDetail staffDetail)
        {

            var d = instance.StaffDetails.Where(x => x.id == staffDetail.id).FirstOrDefault();
            instance.StaffDetails.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("allEmployee");
        }

        // POST: Staff/Delete/5
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
