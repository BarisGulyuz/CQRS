using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Command
{
    public class RegisterUserCommandRequest : IRequest
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
