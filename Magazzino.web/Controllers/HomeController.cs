using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Magazzino.web.Models;
using Microsoft.AspNetCore.Http;
using Magazzino.Service.Implementations;
using Magazzino.Models;

namespace Magazzino.web.Controllers
{
    public class HomeController : Controller
    {
        ProductService productService;

        public HomeController(ProductService _productService)
        {
            productService = _productService;
        }

        public IActionResult Index()
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(IFormCollection producto)
        {
            string libro = producto["s"];
            IEnumerable<ProductViewModel> resultado = ((List<ProductViewModel>)(productService.GetAll().ResultObject())).Where(x => x.ProductNameM.Contains(libro));
            return View("Product/Modelo", resultado);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
