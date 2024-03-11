using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using T_1.Entities;

namespace T_1.Helper
{
    public class JWTService : IJWTService
    {
        public string GenerateToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var permissions = user.Role.Permissions;

            foreach (var permission in permissions)
            {
                claims.Add(new Claim(ClaimTypes.Role, permission.Name.ToString()));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Assalomu-aleykum!"));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            
            var token = new JwtSecurityToken(
                audience: "audience",
                issuer: "issuer",
                claims:  claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}