using HomeRenovtors.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeRenovtors.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Passlogin(Login user)
        {
            //Pass the data to store the record into the table 

            DataTable tbl = new DataTable();
            DBConnection db = new DBConnection();
            tbl =db.CheckLogin("select * from LoginDetail where loginName='" + user.txtName + "'and loginPassword='" + user.txtpassword + "'");

            if (tbl.Rows.Count > 0)
            {
                return View("AdminZone");
            }
            else
            {
                return View("invalid");
            }



        }
        public ActionResult AdminZone()
        {
            return View();
        }

        public ActionResult invalid()
        {
            return View();
        }



    }
}