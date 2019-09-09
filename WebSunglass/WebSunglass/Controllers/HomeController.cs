using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSunglass.Models;
using DataLibary;
using  DataLibary.Logic;
using DataLibary.Models;

namespace WebSunglass.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Customer Sign Up";
            ViewData["id"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Customer cust)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int recodSCreated = CustomerProcessor.CreateCustomer(cust.Id, cust.FirstName, cust.LastName, cust.Email, cust.Password);
                    ViewData["id"] = null;
                    return RedirectToAction("Login");
                }
                catch(Exception e)
                {
                    ViewData["id"] = "Id is uniqe and used";
                }
            } 

            return View(cust);
        }

        public ActionResult Login()
        {
            ViewData["idLogin"] = "";
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(int Id,String Password)
        {
            if (ModelState.IsValid)
            {
                CustomerModel customer=CustomerProcessor.LoginCustomer(Id,Password);
                if(customer == null)
                {
                    ViewData["idLogin"] = "The id don't exist or passrowd was wrong";
                    return View();
                }
                ViewData["idLogin"] = null;
                return Redirect("~/Shop/CustomerHomeShop?id=" + customer.Id + "&FirstName=" + customer.FirstName.Trim() + "&LastName=" + customer.LastName.Trim() +
                    "&Email=" + customer.Email + "&Password=" + customer.Password);

            }
            return View();
        }
    }
}