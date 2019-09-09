using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibary.Models;
using WebSunglass.Models;

namespace WebSunglass.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerHomeShop(CustomerModel cust)
        {
            Product p = new Product { Id = cust.Id, ProductId = -1, Price = -1, Name = "", ImageUrl = null, TypeManOrWoman = "" };
            ViewData["" + cust.Id] = cust.FirstName +" "+ cust.LastName;
            @ViewData["idCustomer"] = cust.Id;
            List <Product> listOfProduct = Models.Product.LoadProduct(cust.Id);
            listOfProduct.Add(p);
            return View(listOfProduct);
        }

        [HttpPost]
        public ActionResult CustomerHomeShop(Product product)
        {
            product.InsertProduct();
            CustomerModel cust = DataLibary.Logic.CustomerProcessor.GetCustomer(product.Id);
            @ViewData["idCustomer"] = cust.Id;
            ViewData["" + cust.Id] = cust.FirstName + " " + cust.LastName;
            return View(Models.Product.LoadProduct(cust.Id));
        }

        [HttpPost]
        public ActionResult Shop(int Id)
        {
            return View();
        }
        
    }
}