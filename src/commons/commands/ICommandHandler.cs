namespace commons.commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
         Task HandleSync(T command);
    }
}