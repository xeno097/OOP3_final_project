using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Data.Entities;
using Magazzino.Models;
using Magazzino.Models.Infraestruture;
using Magazzino.Repository.Framework;
using Magazzino.Service.Base;
using Magazzino.Service.Interfaces;

namespace Magazzino.Service.Implementations
{
    public class SalesService : BaseService<SalesViewModel, Sales>, ISalesService
    {
        public SalesService(IRepository<Sales> repository) : base(repository)
        {
        }

        
    }
}
