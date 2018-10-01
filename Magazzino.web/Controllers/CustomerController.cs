using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet("all")]
        public JsonResult CustomerList()
        {
            var result = _customerService.GetAll();

            return Json(result);
        }

        [HttpGet("find")]
        public JsonResult CustomerFind(int id)
        {
            var result = (List<CustomerViewModel>)_customerService.GetAll().ResultObject;
            var filter = result.Where(x => x.IdCustomerM == id);

            var result2 = _customerService.Find(id);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult CustomerInsert(CustomerViewModel customerViewModel)
        {
            var result = _customerService.Insert( customerViewModel);

            return Json(result.Success);
        }

        [HttpDelete("delete")]
        public JsonResult CustomerDelete(CustomerViewModel customerViewModel)
        {
            var result = _customerService.Delete(customerViewModel);

            return Json(result.Success);
        }





    }
}
