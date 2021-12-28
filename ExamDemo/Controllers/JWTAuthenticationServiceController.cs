using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExamDemo.Model;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Collections.Generic;

namespace ExamDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTAuthenticationServiceController : ControllerBase
    {
        public JWTAuthenticationServiceController()
        {

        }

        [HttpPost]
        [Route("Token")]
        public IActionResult Login([FromBody] Users users)
        {
            var user = _account.LoginStudent(login);

            if (user != null)
            {
                var tokenString = GenerateToken(user);
                return Ok(new { token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }


        private string GenerateToken(Users users)
        {
            //var SecretKey = Encoding.ASCII.GetBytes
            //    ("Do not share this key");

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, users.Email),
                };

            var JWTToken = new JwtSecurityToken(
                issuer: "http://localhost:60064/",
                audience: "http://localhost:60064/",
                claims: authClaims,
                notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                expires: new DateTimeOffset(DateTime.Now.AddHours(1)).DateTime,
                //Using HS256 Algorithm to encrypt Token  
                signingCredentials: new SigningCredentials
                (new SymmetricSecurityKey(Encoding.ASCII.GetBytes("Do not share this key")), SecurityAlgorithms.HmacSha256Signature)
                );
            var token = new JwtSecurityTokenHandler().WriteToken(JWTToken);
            return token;
        }

    }
}
