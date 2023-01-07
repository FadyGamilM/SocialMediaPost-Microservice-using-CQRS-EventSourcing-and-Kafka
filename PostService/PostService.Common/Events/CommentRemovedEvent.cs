using CQRS.Core.Events;
namespace PostService.Common.Events;
public class CommentRemovedEvent : BaseEvent
{
    public CommentRemovedEvent():base(typeof(CommentRemovedEvent))
    {
        
    }

    public Guid CommentId { get; set; }
}