using GamingPlatform.Application.Common.Interfaces;

namespace GamingPlatform.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
