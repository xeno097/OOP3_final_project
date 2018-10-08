using System;
using Magazzino.Models;
using Magazzino.Service.Base;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Service.Interfaces
{
    public interface ISellerService : IBaseService<SellerViewModel>
    {
        ServiceResult Find(string company);
    }
}