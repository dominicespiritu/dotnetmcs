namespace commons.Events
{
    public interface IRejectedEvent : IEvent
    {
        string Message { get; set; }
        string Code { get; set; }    
    }
}