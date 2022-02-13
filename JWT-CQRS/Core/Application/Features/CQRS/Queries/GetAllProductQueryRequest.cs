using JWT_CQRS.Core.Application.DTO;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductQueryRequest : IRequest<List<ProductListDto>>
    {

    }
}
