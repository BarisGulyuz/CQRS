using JWT_CQRS.Core.Application.DTO;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Queries
{
    public class GetAllCategoriesQueryRequest : IRequest<List<CategoryListDto>>
    {
    }
}
