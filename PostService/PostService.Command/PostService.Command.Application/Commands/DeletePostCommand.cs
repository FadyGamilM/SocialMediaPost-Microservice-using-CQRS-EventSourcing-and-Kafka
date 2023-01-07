using CQRS.Core.Commands;

namespace PostService.Command.Application.Commands;
public class DeletePostCommand : BaseCommand
{
    // you can delete your own posts only 
    public string Username { get; set; }
}