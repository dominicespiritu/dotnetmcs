using System.Threading.Tasks; 
namespace commons.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
         Task HandleSync(T @event);
    }
}