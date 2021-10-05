using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Models;
using TechnicalTest.API.Services;

namespace TechnicalTestAPI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult<ProductDto> GetProducts()
        //{
        //    ProductRepository repo = new ProductRepository();
        //    var prods = repo.GetProducts();
        //    return prods;
        //}
    }
}