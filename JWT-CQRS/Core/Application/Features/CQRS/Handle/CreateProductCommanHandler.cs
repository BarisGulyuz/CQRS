using JWT_CQRS.Core.Application.Features.CQRS.Command;
using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Core.Domain;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Handle
{
    public class CreateProductCommanHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IGenericRepository<Product> _repository;

        public CreateProductCommanHandler(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Price = request.Price,
                Stock = request.Stock,
            });
            return Unit.Value;
        }
    }
}
