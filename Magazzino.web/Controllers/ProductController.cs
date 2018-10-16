using System;
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
using Magazzino.web.Models;

namespace Magazzino.web.Controllers
{
    public class ProductController : BaseController
    {
        private ApplicationContext Context = new ApplicationContext();
        private readonly IProductService productService;
        private IHostingEnvironment _environment;
        


        public ProductController(IProductService _productService, IUserService userService, IHostingEnvironment environment) : base(userService)

        {
            _environment = environment;
            productService = _productService;
        }

        // GET: Product
        public IActionResult Index()
        {
            var products = productService.GetAll();

            return View(products.ResultObject);
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductViewModel product = productService.GetById((int)id).ResultObject;
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

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProductM,ProductNameM,DetailsM,MoneyM,IdSellersM,CalM,ImgM,CategoryM,Id,RowId")] ProductViewModel product, [Bind("file")]IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "uploads");
                if (file.FileName.Length > 0)
                {
                    product.ImgM = Path.Combine(uploads, file.FileName);
                    using (var fileStream = new FileStream(product.ImgM, FileMode.Create))
                    {
                            await file.CopyToAsync(fileStream);
                    }
                }
                product.IdSellersM = Global.User.IdUserM;
                
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

            ProductViewModel product = productService.GetById((int)id).ResultObject;
            //product = productService.Update(product).ResultObject;
            
            
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
        public IActionResult Edit([Bind("IdProductM,ProductNameM,DetailsM,MoneyM,IdSellersM,CalM,ImgM,CategoryM,Id,RowId")] ProductViewModel product)
        {
           
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            if (ModelState.IsValid)
            {   
                productService.Update(product);
                
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductViewModel product = productService.GetById(id).ResultObject;
            return View(product);
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
