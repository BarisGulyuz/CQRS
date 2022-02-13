using AutoMapper;
using JWT_CQRS.Core.Application.DTO;
using JWT_CQRS.Core.Application.Features.CQRS.Queries;
using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Core.Domain;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Handle
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<ProductListDto>>
    {
        private readonly IGenericRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IGenericRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync(null);
            return _mapper.Map<List<ProductListDto>>(data);
        }
    }
}
