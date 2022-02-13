using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class CreateCategoryCommandRequest : IRequest
    {
        public string? Name { get; set; }
    }
}
