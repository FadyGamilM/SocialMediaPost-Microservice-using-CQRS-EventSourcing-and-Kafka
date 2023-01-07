using CQRS.Core.Messages;
namespace CQRS.Core.Commands;

// each command object must has at least a `Id` field
public abstract class BaseCommand : Message
{

}