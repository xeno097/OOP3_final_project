using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magazzino.Repository.Migrations;
using Magazzino.Models.Infraestruture;

namespace Magazzino.web.Controllers
{
    
    public class SellerController : Controller
    {
        private readonly ISellerService sellerServices;
        private readonly ApplicationContext _context;

        public SellerController(ISellerService _SellerServices, ApplicationContext context)
        {
            sellerServices = _SellerServices;
            _context = context;
        }

        [HttpGet("all")]
        public JsonResult SellerList()
        {
            var result = sellerServices.GetAll();

            return Json(result);
        }

        //GET: Seller/Index
        public async Task<IActionResult> Index()
        {
            var seller = sellerServices.GetAll();

            return View(seller.ResultObject);
        }

        [HttpGet("find")]
        public JsonResult SellerFind(string company)
        {
            var result = (List<SellerViewModel>)sellerServices.GetAll().ResultObject;
            var filter = result.Where(x => x.CompanyM == company);

            var result2 = sellerServices.Find(company);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult SellerInsert(SellerViewModel sellerViewModel)
        {
            var result = sellerServices.Insert( sellerViewModel);

            return Json(result.Success);
        }

        [HttpDelete("delete")]
        public JsonResult SellerDelete(SellerViewModel sellerViewModel)
        {
            ServiceResult result = sellerServices.Delete(sellerViewModel);

            return Json(result.Success);
        }





    }
}
