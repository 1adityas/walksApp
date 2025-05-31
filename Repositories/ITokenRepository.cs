using Microsoft.AspNetCore.Identity;

namespace application2.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTTOken(IdentityUser user, List<string> roles);
    }
}
