using JWT_CQRS.Core.Application.DTO;
using JWT_CQRS.Core.Application.Features.CQRS.Queries;
using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Core.Domain;
using MediatR;

namespace JWT_CQRS.Core.Application.Features.CQRS.Handle
{
    public class CheckUserQueryRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Role> _roleRepository;

        public CheckUserQueryRequestHandler(IGenericRepository<User> userRepository, IGenericRepository<Role> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await _userRepository.GetByFilterAsync(x => x.Name == request.Name && x.Password == request.Password);
            if(user == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.Name = user.Name;
                dto.Id = user.Id;
                dto.IsExist = true;
                var role = await _roleRepository.GetByFilterAsync(x=> x.Id == user.RoleId);
                if (role != null) dto.Role = role.RoleName;
            }
            return dto;
            
        }
    }
}
