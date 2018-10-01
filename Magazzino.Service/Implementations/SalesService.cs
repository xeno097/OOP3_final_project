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
    public class SalesService :
    BaseService<SalesViewModel, Sales>, ISalesService
    {
        public SalesService(
            IRepository<Sales> salesRepository)
            : base(salesRepository)
        {

        }

        public ServiceResult Find(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<Sales, SalesViewModel>(
                    this.Repository.GetAll(i => i.IdSale == id).Data);

            return serviceResult;
        }
    }
}
