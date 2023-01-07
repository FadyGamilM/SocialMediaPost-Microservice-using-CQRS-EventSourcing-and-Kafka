using CQRS.Core.Commands;

namespace PostService.Command.Application.Commands;

public class NewPostCommand : BaseCommand
{
    // in order to create a new post we need to know the post author and the post content
    public string Author { get; set; }
    public string Content { get; set; }
    
}