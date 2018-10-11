using System;
using System.Collections.Generic;
using Magazzino.Data.Entities;
using Magazzino.Helpers.Infraestructure;
using Magazzino.Helpers.Utils;
using Magazzino.Models;
using System.Linq;
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

        public ServiceResult Find(string username)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            User variable = this.Repository.GetAll(i => i.UserName == username).Data.FirstOrDefault();
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<User, UserViewModel>(variable);

            return serviceResult;
        }

        public ServiceResult ValidateId (int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));
            serviceResult.ResultObject = MapperHelper.Instance.
                Map<User, UserViewModel>(
                    this.Repository.GetAll(i => i.Id != id).Data);

            return serviceResult;

        }
        public ServiceResult ValidateUser(string username, string password)
        {
            ServiceResult serviceResult = new ServiceResult();

            serviceResult.Success = true;
            serviceResult.ResultTitle = Error.GetErrorMessage(Error.CorrectTransaction);
            serviceResult.Messages.Add(Error.GetErrorMessage(Error.CorrectTransaction));

            var result =
                    (((IEnumerable<User>)(this.Repository.GetAll(i => i.UserName == username
                                           && i.Password == password).Data)).FirstOrDefault());

            serviceResult.ResultObject = MapperHelper.Instance.
                Map<User, UserViewModel>(result);

            return serviceResult;
        }

        public override ServiceResult Insert(UserViewModel viewModel)
        {
            ServiceResult serviceResult = new ServiceResult();

            var Entity = MapperHelper.Instance.Map<UserViewModel, User>(viewModel);
            Entity.RowId = Guid.NewGuid().ToString();

            var result = this.Repository.Insert(Entity);

            serviceResult.Success = result.Successfull;
            serviceResult.ResultTitle = (result.Successfull ? Error.GetErrorMessage(Error.CorrectTransaction) : Error.GetErrorMessage(Error.InternalServerError));
            serviceResult.Messages.Add(result.Successfull ? "Inserted" : "Failed");
            serviceResult.ResultObject = MapperHelper.Instance.Map<User, UserViewModel>(result.Data);

            return serviceResult;
        }

    }
}
