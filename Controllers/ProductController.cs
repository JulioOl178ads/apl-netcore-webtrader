using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebTrader.Models;

namespace WebTrader.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        //private List<ProductModel> Products { get; set; }

        public ProductController(ILogger<ProductController> logger)
        {
            //_logger = logger;
            //this.Products = new List<ProductModel>();
            //ProductModel product1 = new ProductModel(1, "S20", "2.400,00", "1.000,00", "Samsung", "S20FE");
            //ProductModel product2 = new ProductModel(2, "PS5", "4.300,00", "3.400,00", "Sony", "Antigo");
            //this.Products.Add(product1);
            //this.Products.Add(product2);
        }

        public IActionResult Index()
        {
            //ViewBag.Products = this.Products;
            return View();
        }

        public IActionResult Incluir()
        {
            //product.IdProduct = 3;
            //this.Products.Add(product);
            //ViewBag.Products = this.Products;
            return View("index");
        }

        public IActionResult Alterar()
        {
            return View("index");
        }
    }
}