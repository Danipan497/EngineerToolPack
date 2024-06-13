using EngineerToolPack.Application.Common.Services;

namespace EngineerToolPack.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
