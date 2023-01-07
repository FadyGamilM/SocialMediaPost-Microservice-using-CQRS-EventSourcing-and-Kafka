using CQRS.Core.Commands;

namespace PostService.Command.Application.Commands;

public class EditPostContentCommand : BaseCommand
{
   // in order to edit the post, we need the updated post content
   public string UpdatedContent { get; set; }   
}