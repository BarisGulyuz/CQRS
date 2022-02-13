using JWT_CQRS.Core.Application.Features.CQRS.Command;
using JWT_CQRS.Core.Application.Features.CQRS.Queries;
using JWT_CQRS.Infrasructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace JWT_CQRS.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest commandRequest)
        {
            await _mediator.Send(commandRequest);
            return Created("", commandRequest);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Token(CheckUserQueryRequest queryRequest)
        {
            var response = await _mediator.Send(queryRequest);
            if (response.IsExist)
            {
                var token = JwtTokenGenarator.GenerateToken(response);
                return Ok(token);
            }
            return BadRequest(response);
        }
    }
}
