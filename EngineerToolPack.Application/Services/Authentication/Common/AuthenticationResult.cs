using EngineerToolPack.Domain.Entities;

namespace EngineerToolPack.Application.Services.Authentication.Common
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}
