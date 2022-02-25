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

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public static ProductModel[] InitializeData()
        {
            List<ProductModel> products = new List<ProductModel>();
            ProductModel product1 = new ProductModel("S20", "2.400,00", "1.000,00", "Samsung", "S20FE");
            ProductModel product2 = new ProductModel("PS5", "4.300,00", "3.400,00", "Sony", "Antigo");
            products.Add(product1);
            products.Add(product2);

            return products.ToArray();
        }

        public IActionResult Index()
        {
            ViewBag.Products = InitializeData();
            return View();
        }
    }
}