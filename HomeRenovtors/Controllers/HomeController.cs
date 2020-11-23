using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Page ";

            return View();
        }


        [HttpPost]
        public ActionResult Passquery(Contact dataBlock)
        {
            //Pass the data to store the record into the table 
            DBConnection db = new DBConnection();
            db.Addcontact("insert into QueryDetail values('" + dataBlock.txtName + "','" + dataBlock.txtContact + "','" + dataBlock.txtMsg + "')");

            return View("taskDone");



        }


        public ActionResult taskDone()
        {
            ViewBag.Title = "Contact Page ";

            return View();
        }



    }
}
