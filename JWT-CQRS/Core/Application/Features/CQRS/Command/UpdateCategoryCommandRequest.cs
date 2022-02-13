using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
