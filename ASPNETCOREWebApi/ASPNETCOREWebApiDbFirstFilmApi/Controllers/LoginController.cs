using ASPNETCOREWebApiDbFirstFilmApi.Models;
using ASPNETCOREWebApiDbFirstFilmApi.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASPNETCOREWebApiDbFirstFilmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IConfiguration _configuration;

        public LoginController(UserManager<AspNetUser> userManager, SignInManager<AspNetUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.UserName);
            if (user == null)
            {
                return Unauthorized();
            }
            PasswordHasher<AspNetUser> passwordHasher = new PasswordHasher<AspNetUser>();
            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, loginDTO.Password);
            //bool result = await _userManager.CheckPasswordAsync(user, loginDTO.Password);

            //if (result == false)
            //{
            //    return Unauthorized();
            //}

            if (result != PasswordVerificationResult.Success)
            {
                return Unauthorized();
            }
            // JWT token gönderecek
            string strToken = GetToken(user.Email);
            return Ok(strToken);
        }

        private string GetToken(string email)
        {
            var authClaims = new List<Claim> {
                    new Claim(ClaimTypes.Email, email)
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:secretKey"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(

                authClaims.ToString(),
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
