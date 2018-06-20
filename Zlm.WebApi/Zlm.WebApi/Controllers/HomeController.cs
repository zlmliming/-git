using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zlm.Domain.Entities;
using Zlm.Service;

namespace Zlm.WebApi.Controllers
{
    public class HomeController : Controller
    {
        ProductService _product = new ProductService();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            List<Product> list = _product.GetCustomerList(x => true).ToList();
            return View();
        }
    }
}
