using CQRS.Core.Events;

namespace PostService.Common.Events;
public class CommentAddedEvent : BaseEvent
{
    public CommentAddedEvent():base(typeof(CommentAddedEvent))
    {
        
    }
    public string Username { get; set; }
    public Guid CommentId { get; set; }
    public string CommentContent { get; set; }
    public DateTime CommentedDate { get; set; }
}