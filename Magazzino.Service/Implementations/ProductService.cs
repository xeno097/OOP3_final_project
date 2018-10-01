using System;
using Magazzino.Data.Entities;
using Magazzino.Helpers.Infraestructure;
using Magazzino.Helpers.Utils;
using Magazzino.Models;
using Magazzino.Models.Infraestruture;
using Magazzino.Repository.Framework;
using Magazzino.Service.Base;
using Magazzino.Service.Interfaces;

namespace Magazzino.Service.Implementations
{
    public class ProductService :
    BaseService<ProductViewModel, Product>, IProductService
    {
        public ProductService(
            IRepository<Product> productRepository)
            : base(productRepository)
        {

        }

    }
}

  