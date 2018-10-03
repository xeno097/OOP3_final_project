using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Magazzino.Repository.Migrations;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        //private ApplicationContext db = new ApplicationContext();

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("all")]
        public JsonResult ProductList()
        {
            var result = _productService.GetAll();

            return Json(result);
        }

        [HttpGet("find")]
        public JsonResult ProductFind(string product)
        {
            var result = (List<ProductViewModel>)_productService.GetAll().ResultObject;
            var filter = result.Where(x => x.ProductNameM == product);

            var result2 = _productService.Find(product);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult ProductInsert(ProductViewModel productViewModel)
        {
            var result = _productService.Insert(productViewModel);

            return Json(result.Success);
        }

        [HttpDelete("delete")]
        public JsonResult ProductDelete(ProductViewModel productViewModel)
        {
            var result = _productService.Delete(productViewModel);

            return Json(result.Success);
        }
        
        //GET: Product/Index
        public ActionResult Product()
        {
            return View();
        }





    }
}
