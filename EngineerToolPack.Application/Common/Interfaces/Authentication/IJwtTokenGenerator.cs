using EngineerToolPack.Domain.Entities;

namespace EngineerToolPack.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
