namespace CQRS.Core.Messages;

public abstract class Message
{
    // the message and command requires unique identifier 
    public Guid Id {get; set;}
}