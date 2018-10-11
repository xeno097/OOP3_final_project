using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Magazzino.Data.Entities;
using Magazzino.Repository.Migrations;
using Magazzino.Service.Interfaces;
using Magazzino.Models;

namespace Magazzino.web.Controllers
{
    public class ProductController : BaseController
    {
        //private readonly ApplicationContext _context;
        private readonly IProductService productService;

        public ProductController(IProductService _productService, IUserService userService) : base(userService)
        {
            productService = _productService;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var products = productService.GetAll();

            return View(products.ResultObject);
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productService.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProduct,ProductName,Details,Money,IdSellers,Cal,Img,Category,Id,RowId,CreatedByUserId,CreatedDate,ModifyByUserId,ModifiedDate")] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                productService.Insert(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productService.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProductM,ProductNameM,DetailsM,MoneyM,IdSellersM,CalM,ImgM,CategoryM,Id,RowId")] ProductViewModel product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productService.Update(product);
                    productService.Save(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists((int)product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productService.Delete();
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = productService.find(id);
            productService.delete(id);
           productService.Save(product
            return RedirectToAction(nameof(Index));
        }


        private bool ProductExists(int id)
        {
            return productService.GetById(e => e.Id == id);
        }


        // Modelo de Producto   
    }
}
