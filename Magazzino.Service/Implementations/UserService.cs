using System;
using System.Collections.Generic;
using System.Text;
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
    public class UserService :
        BaseService<UserViewModel, User>, IUserService
    {
        public UserService(
            IRepository<User> userRepository)
            : base(userRepository)
        {

        }

        public ServiceResult ValidateUser(string username, string password)
        {
            ServiceResult serviceResult = new ServiceResult();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<User, UserViewModel>(
                    this.Repository.GetAll(i => i.UserName == username
                                           && i.Password == password).Data);

            return serviceResult;

        }
    }
}
