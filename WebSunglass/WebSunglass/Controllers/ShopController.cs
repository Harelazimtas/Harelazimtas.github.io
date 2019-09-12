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
        
       
        //When you login and also after you add product, you arrive here.
        public ActionResult CustomerHomeShop()
        {
            CustomerModel cust = new CustomerModel();
            cust.Id = Int32.Parse(TempData.Peek("idCustomer").ToString());
            cust =DataLibary.Logic.CustomerProcessor.GetCustomer(cust.Id);
            TempData["" + cust.Id] = cust.FirstName + " " + cust.LastName;
            TempData["idCustomer"] = cust.Id;
            TempData.Keep();
            Product p = new Product { Id = cust.Id, ProductId = -1, Price = -1, Name = "", Image = null, Type = "" };
            List <Product> listOfProduct = Models.Product.LoadProduct(cust.Id);
            listOfProduct.Add(p);
            return View(listOfProduct);
        }

        //Add product with image to your account.
        [HttpPost]
        public ActionResult CustomerHomeShop(Product product, HttpPostedFileBase Image)
        {
            string ImageName = System.IO.Path.GetFileName(Image.FileName);
            string physicalPath = Server.MapPath("~/Content/ImageShop/"+product.Id+ImageName);
            Image.SaveAs(physicalPath);
            product.Image = product.Id+ImageName;
            product.InsertProduct();
            CustomerModel cust = DataLibary.Logic.CustomerProcessor.GetCustomer(product.Id);
            TempData["idCustomer"] = cust.Id;
            TempData["" + cust.Id] = cust.FirstName + " " + cust.LastName;
            TempData.Keep();
            List<Product> p=Models.Product.LoadProduct(cust.Id);
            return View(p);
        }

        // To see all elment(not include your) in the shop
        public ActionResult shopSunglasses()
        {
            CustomerModel cust = DataLibary.Logic.CustomerProcessor.GetCustomer(Int32.Parse(TempData.Peek("idCustomer").ToString()));
            List<Product> productList = Product.LoadOtherProduct(cust.Id);
            TempData["idCustomer"] = cust.Id;
            TempData.Keep();
            return View(productList);
        }
        
       
    }
}