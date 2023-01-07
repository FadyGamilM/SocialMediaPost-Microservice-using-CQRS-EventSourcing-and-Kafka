using CQRS.Core.Commands;
namespace PostService.Command.Application.Commands;

public class AddCommentCommand: BaseCommand
{
    // in order to add a comment to an existing post we need the comment content and the username who wrote the comment
    // public Guid PostId {get; set;}
    public string Username { get; set; }    
    public string Comment { get; set; }
}