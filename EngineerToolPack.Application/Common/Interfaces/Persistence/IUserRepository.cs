using EngineerToolPack.Domain.Entities;

namespace EngineerToolPack.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        void Add(User user);
    }
}
