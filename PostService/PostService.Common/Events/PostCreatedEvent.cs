using CQRS.Core.Events;
namespace PostService.Common.Events;

public class PostCreatedEvent : BaseEvent
{
    public PostCreatedEvent(): base(nameof(PostCreatedEvent)) 
    {

    }

    public string Author { get; set; }
    public string PostContent { get; set; }
    public DateTime PostedDate { get; set; }
    
}