using JWT_CQRS.Core.Application.Enums;
using JWT_CQRS.Core.Application.Features.CQRS.Command;
using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Core.Domain;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Handle
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IGenericRepository<User> _repository;

        public RegisterUserCommandHandler(IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new User
            {
                RoleId = (int)RoleType.Member,
                Name = request.Name,
                Password = request.Password,
            });
            return Unit.Value;
        }
    }
}
