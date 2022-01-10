using AutoMapper;
using KagamaAdmin.ViewModel;
using KagamaModels.Entities;

namespace KagamaAdmin.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, CartItem>()
                .ForMember(x => x.IdProduct, m => m.MapFrom(a => a.Id))
                .ForMember(x => x.ProductName, m => m.MapFrom(a => a.Title))
                .ForMember(x => x.ProductDesc, m => m.MapFrom(a => a.SubTitle))
                .ForMember(x => x.Img, m => m.MapFrom(a => a.Img1))
                .ForMember(x=>x.Price, m=>m.MapFrom(a=>a.PriceKg))
                .ForMember(x => x.Count, m => m.MapFrom(a => 1));
        }
    }
}
