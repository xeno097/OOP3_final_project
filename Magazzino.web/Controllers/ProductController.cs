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
        private readonly ApplicationContext context;
        private readonly IProductService productService;

        public ApplicationContext Context => context;

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
        public IActionResult Create([Bind("IdProduct,ProductName,Details,Money,IdSellers,Cal,Img,Category,Id,RowId,CreatedByUserId,CreatedDate,ModifyByUserId,ModifiedDate")] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                productService.Insert(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
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
                    Context.Update(product);
                    await Context.SaveChangesAsync();
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
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await Context.Products.FindAsync(id);
            Context.Products.Remove(product);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ProductExists(int id)
        {
            return Context.Products.Any(e => e.Id == id);
           
        }


        // Modelo de Producto   
    }
}
