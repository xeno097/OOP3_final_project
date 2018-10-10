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
                conf.CreateMap<Product, ProductViewModel>().ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct))
                .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                .ForMember(i => i.ProductNameM, opt => opt.MapFrom(x => x.ProductName))
                .ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(i => i.DetailsM, opt => opt.MapFrom(x => x.Details))
                .ForMember(i => i.MoneyM, opt => opt.MapFrom(x => x.Money))
                .ForMember(i => i.IdSellersM, opt => opt.MapFrom(x => x.IdSellers))
                .ForMember(i => i.CalM, opt => opt.MapFrom(x => x.Cal))
                .ForMember(i => i.ImgM, opt => opt.MapFrom(x => x.Img))
                .ForMember(i => i.CategoryM, opt => opt.MapFrom(x => x.Category)).ReverseMap();

                // Mapeo de la entidad cliente a la entidad modelo de ese mismo
                conf.CreateMap<Customer, CustomerViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                .ForMember(i => i.IdCustomerM, opt => opt.MapFrom(x => x.IdCustomer))
                .ForMember(i => i.NameM, opt => opt.MapFrom(x => x.Name))
                .ForMember(i => i.LastNameM, opt => opt.MapFrom(x => x.LastName))
                .ForMember(i => i.MailM, opt => opt.MapFrom(x => x.Mail))
                .ForMember(i => i.LocationM, opt => opt.MapFrom(x => x.Location))
                .ForMember(i => i.MetodoPagoM, opt => opt.MapFrom(x => x.MetodoPago)).ReverseMap();

                // Mapeo de la entidad ventas a la entidad modelo de ese mismo 
                conf.CreateMap<Sales, SalesViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                .ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct))
                .ForMember(i => i.IdClientM, opt => opt.MapFrom(x => x.IdClient))
                .ForMember(i => i.IdProductM, opt => opt.MapFrom(x => x.IdProduct))
                .ForMember(i => i.IdSaleM, opt => opt.MapFrom(x => x.IdSale))
                .ForMember(i => i.IdSellerM, opt => opt.MapFrom(x => x.IdSeller))
                .ForMember(i => i.ProductNameM, opt => opt.MapFrom(x => x.ProductName))
                .ForMember(i => i.PriceM, opt => opt.MapFrom(x => x.Price))
                .ForMember(i => i.LocationClientM, opt => opt.MapFrom(x => x.LocationClient))
                .ForMember(i => i.StatusM, opt => opt.MapFrom(x => x.Status))
                .ForMember(i => i.ShoppingDateM, opt => opt.MapFrom(x => x.ShoppingDate))
                .ForMember(i => i.ArrivalDateM, opt => opt.MapFrom(x => x.ArrivalDate))
                .ForMember(i => i.TransationM, opt => opt.MapFrom(x => x.Transation)).ReverseMap();

                // Mapeo de la entidad vendedor a la entidad modelo de ese mismo
                conf.CreateMap<Seller, SellerViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                .ForMember(i => i.IdSellerM, opt => opt.MapFrom(x => x.IdSeller))
                .ForMember(i => i.CompanyM, opt => opt.MapFrom(x => x.Company))
                .ForMember(i => i.TelM, opt => opt.MapFrom(x => x.Tel))
                .ForMember(i => i.LocationM, opt => opt.MapFrom(x => x.Location))
                .ForMember(i => i.CalM, opt => opt.MapFrom(x => x.Cal))
                .ForMember(i => i.PostM, opt => opt.MapFrom(x => x.Post))
                .ForMember(i => i.PolicyM, opt => opt.MapFrom(x => x.Policy)).ReverseMap();

                // Mapeo de la entidad usuario a la entidad modelo de ese mismo
                conf.CreateMap<User, UserViewModel>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                                                     .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                                                     .ForMember(i => i.IdUserM, opt => opt.MapFrom(x => x.IdUser))
                                                     .ForMember(i => i.UserNameM, opt => opt.MapFrom(x => x.UserName))
                                                     .ForMember(i => i.PasswordM, opt => opt.MapFrom(x => x.Password))
                                                     .ForMember(i => i.TypeM, opt => opt.MapFrom(x => x.Type));

                conf.CreateMap<UserViewModel, User>().ForMember(i => i.Id, opt => opt.MapFrom(x => x.Id))
                                                    .ForMember(i => i.RowId, opt => opt.MapFrom(x => x.RowId))
                                                    .ForMember(i => i.IdUser, opt => opt.MapFrom(x => x.IdUserM))
                                                    .ForMember(i => i.UserName, opt => opt.MapFrom(x => x.UserNameM))
                                                    .ForMember(i => i.Type, opt => opt.MapFrom(x => x.TypeM))
                                                    .ForMember(i => i.Password, opt => opt.MapFrom(x => x.PasswordM));

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
