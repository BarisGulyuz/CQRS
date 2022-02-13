using JWT_CQRS.Core.Application.Features.CQRS.Command;
using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Core.Domain;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Handle
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IGenericRepository<Category> _repository;

        public DeleteCategoryCommandHandler(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if(category != null)
            {
                await _repository.DeleteAsync(category);
            }
            return Unit.Value;

        }
    }
}
