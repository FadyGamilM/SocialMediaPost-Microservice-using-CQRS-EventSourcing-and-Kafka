using CQRS.Core.Events;
namespace PostService.Common.Events;
public class CommentEditedEvent
{
    public CommentEditedEvent(): base(typeof(CommentEditedEvent))
    {
        
    }
    public Guid CommentId { get; set; }
    public string CommentUpdatedContent { get; set; } 
    public string Username { get; set; }   
    public DateTime UpdatedDate { get; set; }
}
