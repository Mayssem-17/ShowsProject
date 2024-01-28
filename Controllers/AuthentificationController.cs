using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShowsProject.Models;
using Microsoft.Extensions.Configuration;
using ShowsProject.Models.Authentification.SignUp;
using ShowsProject.Models.Authentification.Login;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;

namespace ShowsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly LibraryDbContext _context;

        public AuthentificationController(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager, IConfiguration configuration, LibraryDbContext context)

        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
           _context = context;


        }

        [HttpPost]
        public async Task<IActionResult> RegisterOwner([FromBody] Register registerUser, string role)
        {
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);

            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new Response { Status = "Error", Message = "User already exists!" });
            }

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.UserName,
            };

            if (await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user, registerUser.Password);

                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response { Status = "Error", Message = "User not created!" });
                }

                var owner = new Owner
                {
                    Name = registerUser.UserName,
                    UserId = user.Id
                };

                _context.Owners.Add(owner);

                try
                {
                    await _context.SaveChangesAsync();

                    await _userManager.AddToRoleAsync(user, role);

                    return StatusCode(StatusCodes.Status201Created,
                        new Response { Status = "Success", Message = "User created successfully!" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving Owner: {ex.Message}");
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response { Status = "Error", Message = "Failed to save Owner." });
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound,
                    new Response { Status = "Error", Message = "Role not found!" });
            }
        }





        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user,login.Password))
            {
                var authClaim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach(var role in userRoles) {
                    authClaim.Add(new Claim(ClaimTypes.Role, role));
                }

                var jwtToken = GetToken(authClaim);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = jwtToken.ValidTo
                });


            }
            return Unauthorized();
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

    }
}
