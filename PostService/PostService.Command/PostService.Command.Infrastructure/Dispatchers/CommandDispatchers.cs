using System;
using CQRS.Core.Commands;
using CQRS.Core.Infrastructure;
namespace PostService.Command.Infrastructure.Dispatchers;

public class CommandDispatchers : ICommandDispatcher
{
    // first we need to define a dictionary that holds all our command handlers methods as function delegates
    private readonly Dictionary<Type, Func<BaseCommand, Task>> _handlers = new();


//! => this generic handler method allows us to register a command handler method
    // the generic type `T` is one of our concrete commands objects
   public void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand
   {    
        // chekc if we already had registered this handler before
        if( _handlers.ContainsKey(typeof(T)) )
            throw new Exception("You can nott register same handler more than one time");
        // but if we don't have this handler before .. we should register it
        else
            _handlers.Add(
                typeof(T),
                genericCommand => handler((T) genericCommand)
            );
   }

    //!=> this method dispatch the command object to the registered command handler method 
   public async Task SendAsync(BaseCommand command)
   {
        // lets check if we have a handler for this specific command object
        if(_handlers.TryGetValue(command.GetType(), out Func<BaseCommand, Task> handler))
            // call this handler method to handle this command object
            await handler(command);
        else
            throw new Exception("No Command handler method is registered for this command");
   }
}