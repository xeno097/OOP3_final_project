using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Magazzino.web.Controllers
{
    [Route("web/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("all")]
        public JsonResult UserList()
        {
            var result = _userService.GetAll();

            return Json(result);
        }

        [HttpGet("find")]
        public JsonResult UserFind(string username)
        {
            var result = (List<UserViewModel>)_userService.GetAll().ResultObject;
            var filter = result.Where(x => x.UserName == username);

            var result2 = _userService.Find(username);

            return Json(result);
        }

        [HttpPost("add")]
        public JsonResult UserInsert(UserViewModel userViewModel)
        {
            var result = _userService.Insert(userViewModel);

            return Json(result.Success);
        }

       
    }
}
