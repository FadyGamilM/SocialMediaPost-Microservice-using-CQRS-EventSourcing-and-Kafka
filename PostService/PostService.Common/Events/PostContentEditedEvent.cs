using CQRS.Core.Events;

namespace PostService.Common.Events;

public class PostContentEditedEvent : BaseEvent
{
    public PostContentEditedEvent() : base(typeof(PostContentEditedEvent))
    {

    }   

    public string UpdatedContent { get; set; } 
}