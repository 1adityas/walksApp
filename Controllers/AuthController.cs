using application2.Models.DTO;
using application2.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;

namespace application2.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;
        public AuthController(Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            _userManager = userManager;
            _tokenRepository = tokenRepository;
        }

        //POST: /api/Auth/register  
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequest)
        {
            if (registerRequest == null)
            {
                return BadRequest("Invalid registration request.");
            }

            var identityUser = new IdentityUser
            {
                UserName = registerRequest.UserName,
                Email = registerRequest.UserName // Assuming UserName is an email  
            };

            var identityResult = await _userManager.CreateAsync(identityUser, registerRequest.Password);
            if (identityResult.Succeeded)
            {
                if (registerRequest.Roles != null && registerRequest.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequest.Roles);
                }
                if (!identityResult.Succeeded)
                {
                    return BadRequest("Failed to assign roles: " + string.Join(", ", identityResult.Errors.Select(e => e.Description)));
                }
                return Ok("User registered, Please login.");
            }
            else
            {
                return BadRequest("User registration failed: " + string.Join(", ", identityResult.Errors.Select(e => e.Description)));
            }
        }

        // POST: /api/Auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest)
        {
            if (loginRequest == null)
            {
                return BadRequest("Invalid login request.");
            }
            var user = await _userManager.FindByNameAsync(loginRequest.UserName);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginRequest.Password);
                if (passwordCheck)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    // Generate JWT token here (not implemented in this example)
                    if (roles != null && roles.Any())
                    {
                        // You can add logic to handle roles if needed
                        var jwtToken = _tokenRepository.CreateJWTTOken(user, roles.ToList());
                        var response = new LoginResponseDto { JwtToken = jwtToken };
                        return Ok(response);
                    }
                }
            }
            return Unauthorized("Invalid username or password.");
        }
    }
}
