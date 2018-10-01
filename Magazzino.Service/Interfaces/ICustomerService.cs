using System;
using Magazzino.Models;
using Magazzino.Service.Base;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Service.Interfaces
{
    public interface ICustomerService : IBaseService<CustomerViewModel>
    {
        ServiceResult Find(int id);
    }
}