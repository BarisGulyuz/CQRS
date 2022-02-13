using JWT_CQRS.Core.Application.DTO;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
