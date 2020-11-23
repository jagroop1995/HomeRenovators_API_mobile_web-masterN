using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        HomeRenovatorsEntities instance = new HomeRenovatorsEntities();

        public ActionResult allPayments()
        {
            return View(instance.PaymentDetails.ToList());
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
        public ActionResult Create(PaymentDetail paymentDetail)
        {
            if (!ModelState.IsValid)
                return View();
            instance.PaymentDetails.Add(paymentDetail);
            instance.SaveChanges();
            return RedirectToAction("allPayments");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in instance.PaymentDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(PaymentDetail paymentDetail)
        {

            var orignalRecord = (from m in instance.PaymentDetails where m.id == paymentDetail.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            instance.Entry(orignalRecord).CurrentValues.SetValues(paymentDetail);

            instance.SaveChanges();
            return RedirectToAction("allPayments");
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(PaymentDetail paymentDetail)
        {

            var d = instance.PaymentDetails.Where(x => x.id == paymentDetail.id).FirstOrDefault();
            instance.PaymentDetails.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("allPayments");
        }




        // POST: Payment/Delete/5
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
