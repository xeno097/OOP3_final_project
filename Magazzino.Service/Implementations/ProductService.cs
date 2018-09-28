using Magazzino.Data.Entities;
using Magazzino.Models;
using Magazzino.Repository.Framework;
using Magazzino.Service.Base;
using Magazzino.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Service.Implementations
{
    public class ProductService : BaseService<ProductViewModel, Product>, IProductService
    {
        public ProductService(IRepository<Product> repository) : base(repository)
        {
        }
    }
}
