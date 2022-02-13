using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class DeleteCategoryCommandRequest : IRequest
    {
        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
