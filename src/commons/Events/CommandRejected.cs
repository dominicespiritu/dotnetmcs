namespace commons.Events
{
    public class CommandRejected : IRejectedEvent
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }


        protected CommandRejected(){

        }

        public CommandRejected(string email, string message, string code){
            Email = email;
            Message = message;
            Code = code;
        }
    }
}