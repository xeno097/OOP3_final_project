using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class SellerController : Controller
    {
        private readonly ISellerService _sellerServices;

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

        //GET: Account/Index
        public ActionResult SellerContact()
        {
            return View();
        }

        [HttpGet("find")]
        public JsonResult SellerFind(string company)
        {
            var result = (List<SellerViewModel>)_sellerServices.GetAll().ResultObject;
            var filter = result.Where(x => x.CompanyM == company);

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
