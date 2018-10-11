using System;
using Magazzino.Models;
using Magazzino.Service.Base;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Service.Interfaces
{
    public interface IProductService : IBaseService<ProductViewModel>
    {

        ServiceResult Find(string product);
<<<<<<< HEAD
=======
        ServiceResult find(int id);
        ServiceResult Save(ProductViewModel product);
        ServiceResult delete(int id);
      
>>>>>>> 5376efebe8a45a32345886f2164622d84be18a7c
    }
}