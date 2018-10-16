using System;
using Magazzino.Models;
using Magazzino.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magazzino.Repository.Migrations;
using Magazzino.Models.Infraestruture;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

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
        public IActionResult Index()
        {
            var products = sellerServices.GetAll();
            return View(products.ResultObject);
        }

        // Get: Seller/Details
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            SellerViewModel seller = sellerServices.GetById((int)id).ResultObject;
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
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

        // GET: Seller/Delete/5
        public IActionResult Delete(int id)
        {
            SellerViewModel seller = sellerServices.GetById(id).ResultObject;
            return View(seller);
        }

        // POST: Seller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SellerViewModel seller = sellerServices.GetById((int)id).ResultObject();
            sellerServices.Delete(seller);
            return RedirectToAction(nameof(Index));
        }


        // GET: Product/Edit/4
        public IActionResult Edit(int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }
            SellerViewModel seller = sellerServices.GetById((int)id).ResultObject;

            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("IdSellerM,CompanyM,TelM,LocationM,CalM,PolicyM,Id,RowId")] SellerViewModel seller)
        {
            if (seller == null)
            {
                throw new ArgumentNullException(nameof(seller));
            }

            if (ModelState.IsValid)
            {
                sellerServices.Update(seller);

            }
            return RedirectToAction("Index");
        }





    }
}
