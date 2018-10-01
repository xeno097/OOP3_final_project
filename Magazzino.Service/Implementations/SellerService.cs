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
    public class SellerService :
    BaseService<SellerViewModel, Seller>, ISellerService
    {
        public SellerService(
            IRepository<Seller> sellerRepository)
            : base(sellerRepository)
        {

        }

        public ServiceResult Find(string company)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<Seller, SellerViewModel>(
                    this.Repository.GetAll(i => i.Company == company).Data);

            return serviceResult;
        }
    }
}
