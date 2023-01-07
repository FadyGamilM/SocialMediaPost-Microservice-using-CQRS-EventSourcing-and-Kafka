using CQRS.Core.Commands;
namespace PostService.Command.Application.Commands;

public class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    // u can't remove somebody's comments
    public string Username { get; set; }
}