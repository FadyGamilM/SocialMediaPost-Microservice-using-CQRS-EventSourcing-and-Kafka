using CQRS.Core.Commands;

namespace PostService.Command.Application.Commands;

public class EditCommentCommand: BaseCommand
{
    // the required data is the comment id and the new comment content
    public Guid CommentId { get; set; }
    public string NewCommentContent {get; set;}
    // the username of that user who is trying to edit this comment
    // to avoid that someone might edit another one comment
    public string Username { get; set; }
}