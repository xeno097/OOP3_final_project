using System;
using Magazzino.Models;
using Magazzino.Service.Base;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Service.Interfaces
{
    public interface ISalesService : IBaseService<SalesViewModel>
    {
        ServiceResult Find(int id);
    }
}