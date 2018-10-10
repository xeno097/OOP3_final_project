using AutoMapper;
using Magazzino.Data.Entities;
using Magazzino.Models;


namespace Magazzino.Helpers.Utils
{
    public class MapperHelper
    {
        static MapperHelper _instance;

        MapperHelper()
        {
            Mapper.Initialize(conf =>
            {
                // Mapeo de la entidad producto a la entidad modelo de ese mismo
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.ProductNameM, opt => opt.MapFrom(x => x.ProductName));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.DetailsM, opt => opt.MapFrom(x => x.Details));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.MoneyM, opt => opt.MapFrom(x => x.Money));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.IdSellersM, opt => opt.MapFrom(x => x.IdSellers));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.CalM, opt => opt.MapFrom(x => x.Cal));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.ImgM, opt => opt.MapFrom(x => x.Img));
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.CategoryM, opt => opt.MapFrom(x => x.Category));

                // Mapeo de la entidad cliente a la entidad modelo de ese mismo
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.IdCustomerM, opt => opt.MapFrom(x => x.IdCustomer));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.NameM, opt => opt.MapFrom(x => x.Name));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.LastNameM, opt => opt.MapFrom(x => x.LastName));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.MailM, opt => opt.MapFrom(x => x.Mail));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.LocationM, opt => opt.MapFrom(x => x.Location));
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.MetodoPagoM, opt => opt.MapFrom(x => x.MetodoPago));

                // Mapeo de la entidad ventas a la entidad modelo de ese mismo 
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.IdClientM, opt => opt.MapFrom(x => x.IdClient));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.IdSaleM, opt => opt.MapFrom(x => x.IdSale));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.IdSellerM, opt => opt.MapFrom(x => x.IdSeller));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.ProductNameM, opt => opt.MapFrom(x => x.ProductName));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.PriceM, opt => opt.MapFrom(x => x.Price));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.LocationClientM, opt => opt.MapFrom(x => x.LocationClient));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.StatusM, opt => opt.MapFrom(x => x.Status));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.ShoppingDateM, opt => opt.MapFrom(x => x.ShoppingDate));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.ArrivalDateM, opt => opt.MapFrom(x => x.ArrivalDate));
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.TransationM, opt => opt.MapFrom(x => x.Transation));

                // Mapeo de la entidad vendedor a la entidad modelo de ese mismo
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.Id , opt => opt.MapFrom(x => x.Id));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.IdSellerM, opt => opt.MapFrom(x => x.IdSeller));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.CompanyM, opt => opt.MapFrom(x => x.Company));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.TelM, opt => opt.MapFrom(x => x.Tel));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.LocationM, opt => opt.MapFrom(x => x.Location));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.CalM, opt => opt.MapFrom(x => x.Cal));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.PostM, opt => opt.MapFrom(x => x.Post));
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.PolicyM, opt => opt.MapFrom(x => x.Policy));

                // Mapeo de la entidad usuario a la entidad modelo de ese mismo
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.Id , opt => opt.MapFrom( x => x.Id ));
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId));
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.IdUserM, opt => opt.MapFrom(x => x.IdUser));
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.UserNameM, opt => opt.MapFrom(x => x.UserName));
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.TypeM, opt => opt.MapFrom(x => x.Type));
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.PasswordM, opt => opt.MapFrom(x => x.Password));


            });
        }

        public static MapperHelper Instance
        {
            get{
                if(_instance == null)
                {
                    _instance = new MapperHelper();
                }

                return _instance;
            }
        }

        public To Map<From, To>(From obj)
        {
            return Mapper.Map<To>(obj);
        }

        public To Map<From, To>(From from, To to)
        {
            return Mapper.Map(from, to);
        }
    }
}
