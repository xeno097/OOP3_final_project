using Magazzino.Models;
using Magazzino.Models.Infraestruture;
using Magazzino.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Service.Interfaces
{
    public interface IUserService : IBaseService<UserViewModel>
    {
        ServiceResult ValidateUser(string username, string password);
    }
}
