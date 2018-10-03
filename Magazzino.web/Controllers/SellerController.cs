using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Magazzino.Repository.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class SellerController : Controller
    {
        private readonly ISellerService _sellerServices;
        private ApplicationContext db;

        public SellerController(ISellerService sellerServices)
        {
     
            this._sellerServices = sellerServices;
        }

        [HttpGet("all")]
        public JsonResult SellerList()
        {
            var result = _sellerServices.GetAll();

            return Json(result);
        }

        //GET: Seller/Index
        public ActionResult Index()
        {
            var result = (List<SellerViewModel>)_sellerServices.GetAll().ResultObject;

            return View(result.ToList());
        }

        [HttpGet("find")]
        public JsonResult SellerFind(string company)
        {
            var result = (List<SellerViewModel>)_sellerServices.GetAll().ResultObject;
            var filter = result.Where(x => x.Company == company);

            var result2 = _sellerServices.Find(company);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult SellerInsert(SellerViewModel sellerViewModel)
        {
            var result = _sellerServices.Insert( sellerViewModel);

            return Json(result.Success);
        }

        [HttpDelete("delete")]
        public JsonResult SellerDelete(SellerViewModel sellerViewModel)
        {
            var result = _sellerServices.Delete(sellerViewModel);

            return Json(result.Success);
        }





    }
}
