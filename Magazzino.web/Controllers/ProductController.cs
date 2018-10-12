﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Magazzino.Data.Entities;
using Magazzino.Repository.Migrations;
using Magazzino.Service.Interfaces;
using Magazzino.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Magazzino.web.Controllers
{
    public class ProductController : BaseController
    {
        //private readonly ApplicationContext _context;
        private readonly IProductService productService;
        private IHostingEnvironment _environment;

        public ProductController(IProductService _productService, IUserService userService, IHostingEnvironment environment) : base(userService)
        {
            _environment = environment;
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
        public async Task<IActionResult> Create([Bind("IdProductM,ProductNameM,DetailsM,MoneM,IdSellersM,CalM,ImgM,CategoryM,Id,RowIdM")] ProductViewModel product, [Bind("file")]IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "uploads");
                if (file.Length > 0)
                {
                    product.ImgM = Path.Combine(uploads, file.FileName);
                    using (var fileStream = new FileStream(product.ImgM, FileMode.Create))
                    {
                            await file.CopyToAsync(fileStream);
                    }
                }

                
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
        public async Task<IActionResult> Edit(int id, [Bind("IdProduct,ProductName,Details,Money,IdSellers,Cal,Img,Category,Id,RowId,CreatedByUserId,CreatedDate,ModifyByUserId,ModifiedDate")] ProductViewModel product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                /*try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }*/
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }*/

            //return View(product);
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var product = await _context.Products.FindAsync(id);
            //_context.Products.Remove(product);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ProductExists(int id)
        {
            //return _context.Products.Any(e => e.Id == id);
            return false;
        }


        // Modelo de Producto   
    }
}
