using System;
using Magazzino.Models;
using Magazzino.Models.Infraestruture;
using Magazzino.Service.Base;

namespace Magazzino.Service.Interfaces
{
    public interface IUserService : IBaseService<UserViewModel>
    {
        ServiceResult ValidateUser(string username, string password);
    }
}
