using AutoMapper;
using JWT_CQRS.Core.Application.DTO;
using JWT_CQRS.Core.Domain;

namespace JWT_CQRS.Core.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
