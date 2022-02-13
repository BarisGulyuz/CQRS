using AutoMapper;
using JWT_CQRS.Core.Application.DTO;
using JWT_CQRS.Core.Domain;

namespace JWT_CQRS.Core.Application.Mappings
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
