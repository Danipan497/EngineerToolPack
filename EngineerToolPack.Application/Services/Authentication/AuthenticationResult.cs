using EngineerToolPack.Domain.Entities;

namespace EngineerToolPack.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}
