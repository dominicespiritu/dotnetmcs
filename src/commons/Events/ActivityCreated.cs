using System; 
namespace commons.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; }
        public Guid UserId { get; set; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }

        protected ActivityCreated(){

        }

        public ActivityCreated(Guid id, Guid userId, string category, string name, string description, DateTime createdAt){
            Id = id;
            UserId = userId;
            Category = category;
            Name = name;
            description = Description;
            CreatedAt = createdAt;

        }

        
    }
}