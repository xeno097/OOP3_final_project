using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class SalesController : Controller
    {
        private readonly ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            this._salesService = salesService;
        }

        [HttpGet("all")]
        public JsonResult SalesList()
        {
            var result = _salesService.GetAll();

            return Json(result);
        }

        [HttpGet("find")]
        public JsonResult SalesFind(int id)
        {
            var result = (List<SalesViewModel>)_salesService.GetAll().ResultObject;
            var filter = result.Where(x => x.IdSaleM == id);

            var result2 = _salesService.Find(id);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult SalesInsert(SalesViewModel salesViewModel)
        {
            var result = _salesService.Insert(salesViewModel);

            return Json(result.Success);
        }

        [HttpDelete("delete")]
        public JsonResult SalesDelete(SalesViewModel salesViewModel)
        {
            var result = _salesService.Delete(salesViewModel);

            return Json(result.Success);
        }





    }
}
