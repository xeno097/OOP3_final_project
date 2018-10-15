﻿using System;
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

        public ServiceResult Find(string product)
        {
            ServiceResult serviceResult = new ServiceResult();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<User, UserViewModel>(
                    this.Repository.GetAll(i => i.ProductName == product
                                           ).Data);
            
            return serviceResult;
        }

       
    }
}

  