using JWT_CQRS.Core.Application.DTO;
using JWT_CQRS.Core.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_CQRS.Infrasructure.Tools
{
    public class JwtTokenGenarator
    {
        public static string GenerateToken(CheckUserResponseDto userResponse)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Role, userResponse.Role));
            claims.Add(new Claim(ClaimTypes.Name, userResponse.Name));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, userResponse.Id.ToString()));



            JwtSecurityToken token = new JwtSecurityToken(
                issuer: JwtTokenSettings.Issuer,
                audience: JwtTokenSettings.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddDays(JwtTokenSettings.Expire),
                signingCredentials: credentials
                );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }
    }
}
