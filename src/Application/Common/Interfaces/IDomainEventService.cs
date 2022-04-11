using GamingPlatform.Domain.Common;

namespace GamingPlatform.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
