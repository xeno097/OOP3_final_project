using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Magazzino.web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUserService _userService;

        public BaseController(IUserService userService)
        {
            this._userService = userService;
        }

        public UserViewModel LoggedUser
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    Claim claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

                    if (claim == null)
                    {
                        return new UserViewModel();
                    }

                    UserViewModel viewModel = new UserViewModel();
                    viewModel.Id = Convert.ToInt32(claim.Value);

                    var model = this._userService.GetById((int)viewModel.Id).ResultObject;

                    return model;
                }

                return new UserViewModel();
            }
        }
    }
}