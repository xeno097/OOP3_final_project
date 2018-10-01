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
    public class CustomerService :
    BaseService<CustomerViewModel, Customer>, ICustomerService
    {
        public CustomerService(
            IRepository<Customer> customerRepository)
            : base(customerRepository)
        {

        }

        public ServiceResult Find(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<Customer, CustomerViewModel>(
                    this.Repository.GetAll(i => i.IdCustomer == id).Data);

            return serviceResult;
        }
    }
}

