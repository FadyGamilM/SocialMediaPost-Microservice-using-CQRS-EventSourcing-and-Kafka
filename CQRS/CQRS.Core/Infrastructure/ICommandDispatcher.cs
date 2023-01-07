using CQRS.Core.Commands;

namespace CQRS.Core.Infrastructure;

public interface ICommandDispatcher
{
    // method for : register a command handler method
    //!=> we return one out param of type Task bc we need our command_handler_method to be async tasks
    //!=> the output param called handler 
    void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand;

    // memthod for : sending / dispatching a command object
    Task SendAsync(BaseCommand command);
}