using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class DeleteProductCommanRequest : IRequest
    {
        public int Id { get; set;}
        public DeleteProductCommanRequest(int id)
        {
            Id = id;
        }
    }
}
