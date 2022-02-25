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
            ProductModel product1 = new ProductModel("nome1", "precoMercado1", "precoDesejado1", "marca1", "modelo1");
            ProductModel product2 = new ProductModel("nome2", "precoMercado2", "precoDesejado2", "marca2", "modelo2");
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