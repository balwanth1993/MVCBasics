using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                Id = 1,Name= "Balwanth", City="Hyderabad",Gender="Male"
            };
            return View(emp);
        }
        public ActionResult Account()
        {
            return Redirect("~/Home/Details");
        }
        public ActionResult Partial()
        {
            return PartialView("Partial","Employee");
        }
        public ActionResult Content()
        {
            return Content();
        }
        public ActionResult File()
        {
            return File();
        }
    }
}