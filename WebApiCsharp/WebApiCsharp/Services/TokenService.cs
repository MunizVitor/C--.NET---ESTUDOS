using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiCsharp.Model.User;

namespace WebApiCsharp.Services
{
    public class TokenService
    {
        public static object GeneratedToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim("userId", user.id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHadler = new JwtSecurityTokenHandler();
            var token = tokenHadler.CreateToken(tokenConfig);
            var tokenString = tokenHadler.WriteToken(token);

            return new { token = tokenString };  
        }
    }
}
