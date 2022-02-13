using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class CreateProductCommandRequest : IRequest
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
