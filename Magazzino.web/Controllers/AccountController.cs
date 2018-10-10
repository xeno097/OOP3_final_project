using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazzino.Data.Entities;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magazzino.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly ICustomerService customerService;
        private readonly ISellerService sellerService;

        public AccountController(IUserService _userService, ICustomerService _customerService, ISellerService _sellerService)
        {
            userService = _userService;
            customerService = _customerService;
            sellerService = _sellerService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormCollection user)
        {
            UserViewModel usuario = userService.Find(user["User"]).ResultObject();
            if (usuario.PasswordM == user["Password"])
            {
                
                return View();
            }
            

            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: Account/Registro
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(IFormCollection form)
        {
            UserViewModel user = new UserViewModel();
            int id = userService.GenerateId();
            user.IdUserM = id;
            user.UserNameM = form["UserNameM"];
            user.PasswordM = form["PasswordM"];
            user.TypeM = form["TypeM"];
            userService.Insert(user);
            if(user.TypeM == "0")
            {
                CustomerViewModel customer = new CustomerViewModel
                {
                    IdCustomerM = id,
                    LastNameM = form["LastNameM"],
                    LocationM = form["LocationM"],
                    MailM = form["MailM"],
                    MetodoPagoM = form["MetodoPagoM"],
                    NameM = form["NameM"]
                };
                customerService.Insert(customer);
            }

            if(user.TypeM == "1")
            {
                SellerViewModel seller = new SellerViewModel
                {
                    IdSellerM = id,
                    LocationM = form["LocationM"],
                    PolicyM = form["PolicyM"],
                    PostM = form["PostM"],
                    TelM = form["TelM"]
                };
                sellerService.Insert(seller);
            }

            return View();
        }
    }
}