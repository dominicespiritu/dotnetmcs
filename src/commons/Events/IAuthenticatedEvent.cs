using System; 
namespace commons.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
         Guid UserId { get; }
    }
}